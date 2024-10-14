using BookStore.Entities;

namespace BookStore.Repository.Interfaces
{
    public interface IBookRepository
    {
        Task<ICollection<Book>> GetAsync();
        Task<Book?> GetAsync(int id);
        Task<int> AddAsync(Book entity);
        Task UpdateAsync();
        Task DeleteAsync(int id);
    }
}
