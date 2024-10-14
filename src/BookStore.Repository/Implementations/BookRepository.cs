using BookStore.Entities;
using BookStore.Persistence;
using BookStore.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;

        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public virtual async Task<ICollection<Book>> GetAsync()
        {
            return await context.Set<Book>()
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<Book?> GetAsync(int id)
        {
            return await context.Set<Book>().FindAsync(id);
        }
        public virtual async Task<int> AddAsync(Book entity)
        {
            await context.Set<Book>()
                .AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id;
        }
        public virtual async Task UpdateAsync()
        {
            await context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var item = await GetAsync(id);

            if (item is not null)
            {
                item.Status = false;
                await UpdateAsync();
            }
        }
    }
}
