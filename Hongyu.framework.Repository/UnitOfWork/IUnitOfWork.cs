namespace Hongyu.framework.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        MSSQLDbContext GetDbContext();

        Task<int> SaveChangesAsync();
    }
}
