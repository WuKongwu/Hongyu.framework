using Hongyu.framework.IRepository;
using Hongyu.framework.Models.Entitys;

namespace Hongyu.framework.Repository
{
    public class UserRepository : IBaseRepository<UserEntity>, IUserRepository
    {
        public void AddEntity(UserEntity t)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(UserEntity t)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(UserEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
