using System.Linq.Expressions;

namespace App.BP.Repository.Interfaces
{
    public interface IRepository<T>:IAsyncDisposable where T : class
    {
        Task<T> GetEntityByIdAsync(int id);
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> SearchByAsync(Expression<Func<T, bool>> predicate);
        Task<T> CreateEntityAsync(T entity);
        Task<T> UpdateEntityAsync(T entity);
        Task DeleteEntityAsync(int id);
        Task<int> SaveAsync();
        
        
    }
}
