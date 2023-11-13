using Hongyu.framework.Models.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Hongyu.framework.Repository
{
    public class MSSQLDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(@"Data Source=192.168.190.2;Initial Catalog=DrugReport_Test;Id = sa;Password=1;Integrated Security=True;");
        //public MSSQLDbContext(DbContextOptions<MSSQLDbContext> options):base(options)
        //{Server=192.168.190.2;Database=DrugReport_Test;Id = sa;Password=1,MultipleActiveResultSets=true
        //}
        public DbSet<UserEntity> User { get; set; }
    }
}
