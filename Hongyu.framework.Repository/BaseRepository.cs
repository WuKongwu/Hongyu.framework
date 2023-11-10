using Hongyu.framework.IRepository;
using Hongyu.yu.framework.Extensions.Interfaces;

namespace Hongyu.framework.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        public void AddEntity(T t)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(T t)
        {
            throw new NotImplementedException();
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
