using Hongyu.framework.Models.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Hongyu.framework.Repository
{
    public class MSSQLDbContext : DbContext
    {
        public MSSQLDbContext(DbContextOptions<MSSQLDbContext> options):base(options)
        {
        }
        public DbSet<UserEntity> User { get; set; }
    }
}
