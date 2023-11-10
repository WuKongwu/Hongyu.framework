namespace Hongyu.framework.IRepository
{
    public interface IDbContextFactory<out T> where T : class
    {
        T CreateDbContext();
    }
}
