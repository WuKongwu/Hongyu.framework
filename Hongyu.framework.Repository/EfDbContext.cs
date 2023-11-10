using Hongyu.framework.IRepository;
using System.Data.Entity;

namespace Hongyu.framework.Repository
{
    public class EfDbContext : IDbContextFactory<DbContext>
    {
        public EfDbContext() 
        {

        }
        public DbContext CreateDbContext()
        {

            return new DbContext("");
        }
    }
}
