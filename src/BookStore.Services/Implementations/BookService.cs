using BookStore.Dto.Requests;
using BookStore.Dto.Responses;
using BookStore.Services.Interfaces;

namespace BookStore.Services.Implementations
{
    public class BookService : IBookService
    {
        public Task<int> AddAsync(BookRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<BookResponseDto>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookResponseDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, BookRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
