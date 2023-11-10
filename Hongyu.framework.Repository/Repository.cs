using Hongyu.framework.Common.AppSetting;
using Hongyu.framework.IRepository;
using System.Data.Entity;

namespace Hongyu.framework.Repository
{
    public class Repository<T> : MSSQLDbContext, IRepository<T> where T : class
    {
        DbContext _dbContext;   
        public Repository() {
            _dbContext =new MSSQLDbContext().CreateDbContext(AppSettings.app(new string[] { "ConnectionStrings", "EXAMPLE_MODEL" }).ToString());
        }
        public void AddEntity(T t)
        {
            _dbContext.Entry<T>(t);
        }

        public void DeleteEntity(T t)
        {
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(T t)
        {
            throw new NotImplementedException();
        }
    }
}
