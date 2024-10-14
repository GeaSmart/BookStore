using BookStore.Dto.Requests;
using BookStore.Dto.Responses;

namespace BookStore.Services.Interfaces
{
    public interface IBookService
    {
        Task<ICollection<BookResponseDto>> GetAsync();
        Task<BookResponseDto> GetAsync(int id);
        Task<int> AddAsync(BookRequestDto request);
        Task<bool> UpdateAsync(int id, BookRequestDto request);
        Task<bool> DeleteAsync(int id);
    }
}
