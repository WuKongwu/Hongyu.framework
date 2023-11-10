using Hongyu.framework.IRepository;
using Hongyu.framework.Models.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Hongyu.framework.Repository
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository() { 
        
        }

        public void AddEntity(UserEntity t)
        {
            throw new NotImplementedException();
        }

        public DbContext CreateDbContext()
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
