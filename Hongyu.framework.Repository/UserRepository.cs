using Hongyu.framework.IRepository;
using Hongyu.framework.Models.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Hongyu.framework.Repository
{
    public class UserRepository : IUserRepository,IRepository<UserEntity>
    {
        public UserRepository() { 
        
        }
        public Task<int> Delete(Expression<Func<UserEntity, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetEntity(Expression<Func<UserEntity, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public ValueTask<EntityEntry<UserEntity>> Insert(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExist(Expression<Func<UserEntity, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> Select()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> Select(Expression<Func<UserEntity, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<List<UserEntity>, int>> Select<S>(int pageSize, int pageIndex, Expression<Func<UserEntity, bool>> whereLambda, Expression<Func<UserEntity, S>> orderByLambda, bool isAsc)
        {
            throw new NotImplementedException();
        }

        public void Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Expression<Func<UserEntity, bool>> whereLambda, Expression<Func<UserEntity, UserEntity>> entity)
        {
            throw new NotImplementedException();
        }
    }
}
