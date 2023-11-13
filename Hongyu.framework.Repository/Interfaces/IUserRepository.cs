using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Hongyu.yu.framework.Extensions.Interfaces;
namespace Hongyu.framework.Repository.Interfaces
{
    public interface IUserRepository : IDependency
    {
        UserOutputModel FindUsers(UserInputModel inputModel);
    }
}
