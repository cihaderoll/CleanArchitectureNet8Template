using CleanArchitectrure.Application.Interface.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectrure.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public Task<bool> DeleteAsync(string id)
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

        public Task<bool> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
