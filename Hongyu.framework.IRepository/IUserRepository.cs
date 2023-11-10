using Hongyu.framework.Models.Entitys;
using Hongyu.yu.framework.Extensions.Interfaces;

namespace Hongyu.framework.IRepository
{
    public interface IUserRepository : IBaseRepository<UserEntity>, IDependency
    {
    }
}
