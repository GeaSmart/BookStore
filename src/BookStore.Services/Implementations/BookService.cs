using AutoMapper;
using BookStore.Dto.Requests;
using BookStore.Dto.Responses;
using BookStore.Entities;
using BookStore.Repository.Interfaces;
using BookStore.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace BookStore.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repository;
        private readonly ILogger<BookService> logger;
        private readonly IMapper mapper;

        public BookService(IBookRepository repository, ILogger<BookService> logger, IMapper mapper)
        {
            this.repository = repository;
            this.logger = logger;
            this.mapper = mapper;
        }
        public async Task<ICollection<BookResponseDto>> GetAsync()
        {
            var response = new List<BookResponseDto>();
            try
            {
                logger.LogInformation("Obteniendo todos los generos...");
                response = mapper.Map<List<BookResponseDto>>(await repository.GetAsync());
            }
            catch (Exception ex)
            {                
                logger.LogError(ex, ex.Message);
            }
            return response;
        }

        public async Task<BookResponseDto> GetAsync(int id)
        {
            var response = new BookResponseDto();
            try
            {
                response = mapper.Map<BookResponseDto>(await repository.GetAsync(id));                
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return response;
        }
        public async Task<int> AddAsync(BookRequestDto request)
        {
            var response = new int();
            try
            {
                response = await repository.AddAsync(mapper.Map<Book>(request));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return response;
        }
        public async Task<bool> UpdateAsync(int id, BookRequestDto request)
        {
            var response = false;
            try
            {
                var entity = await repository.GetAsync(id);
                if (entity is null)
                {
                    return response;
                }

                mapper.Map(request, entity);
                await repository.UpdateAsync();
                response = true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return response;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var response = false;
            try
            {
                await repository.DeleteAsync(id);
                response = true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            return response;
        }
    }
}