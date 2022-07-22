using System.Linq.Expressions;
using TicketApp.Models;

namespace TicketApp.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(int id, T entity);
        Task AddAsync(T entity);
        Task DeleteAsync(int id);

    }
}
