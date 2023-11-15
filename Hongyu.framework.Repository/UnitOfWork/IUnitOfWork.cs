using Hongyu.framework.Common.IDependencies;

namespace Hongyu.framework.Repository.UnitOfWork
{
    public interface IUnitOfWork : ITransientDependency
    {
        //MSSQLDbContext GetDbContext();

        Task<int> SaveChangesAsync();
    }
}
