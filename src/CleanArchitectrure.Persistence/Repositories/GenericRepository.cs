using CleanArchitectrure.Application.Interface.Persistence;
using CleanArchitectrure.Domain.Commons;
using CleanArchitectrure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectrure.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly AppDbContext _ctx;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _ctx = context;
            _dbSet = _ctx.Set<TEntity>();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void UpdateAsync(TEntity entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
        }
    }
}
