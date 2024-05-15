using CleanArchitectrure.Application.Interface.Persistence;
using CleanArchitectrure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CleanArchitectrure.Persistence.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; }

        public ICustomerRepository Customers { get; }

        private readonly AppDbContext _context;

        public UnitOfWork(IUserRepository users, 
                          ICustomerRepository customers,
                          AppDbContext context)
        {
            Users = users ?? throw new ArgumentNullException(nameof(users));
            Customers = customers ?? throw new ArgumentNullException(nameof(customers));
            _context = context ?? throw new ArgumentNullException();
        }

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
