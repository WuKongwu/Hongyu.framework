namespace Hongyu.framework.Repository.Interfaces
{
    public interface IDbContextFactory<T>
    {
      public  T CreateDbContext(string conn);
    }
}
