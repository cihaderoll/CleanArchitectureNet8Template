using Microsoft.EntityFrameworkCore.Storage;

namespace CleanArchitectrure.Application.Interface.Persistence
{
    public interface IUnitOfWork: IDisposable
    {
        Task<IDbContextTransaction> BeginTransaction();

        Task Commit();
    }
}
