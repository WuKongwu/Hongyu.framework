using Microsoft.EntityFrameworkCore;

namespace Hongyu.framework.IRepository
{
    public interface IDbContextFactory<T>
    {
      public  T CreateDbContext(string conn);
    }
}
