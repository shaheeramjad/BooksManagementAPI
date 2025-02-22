using BookManagmentSystem.Models;

namespace BookManagmentSystem.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Books> Books { get; }
        Task<int> SaveChangesAsync();
    }
}