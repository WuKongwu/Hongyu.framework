using Hongyu.framework.Models.Entitys;
using Hongyu.yu.framework.Extensions.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hongyu.framework.IRepository
{
    public interface IUserRepository : IRepository<UserEntity>, IDependency
    {
    }
}
