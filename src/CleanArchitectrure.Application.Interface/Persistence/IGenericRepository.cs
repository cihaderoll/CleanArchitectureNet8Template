namespace CleanArchitectrure.Application.Interface.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        /* Commands */
        Task InsertAsync(T entity);
        void UpdateAsync(T entity);
        Task DeleteAsync(string id);
        /* Queries */
        Task<T> GetAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
