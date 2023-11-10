using Hongyu.framework.Common.AppSetting;
using Hongyu.framework.IRepository;
using System.Data.Entity;

namespace Hongyu.framework.Repository
{
    public class MSSQLDbContext : IDbContextFactory<DbContext>
    {
        public DbContext CreateDbContext(string conn)
        {
          
            return new DbContext(conn);
        }
      
    }
}
