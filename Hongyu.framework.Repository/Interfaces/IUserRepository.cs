using Hongyu.framework.Common.IDependencies;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
namespace Hongyu.framework.Repository.Interfaces
{
    public interface IUserRepository : IScopeDependency
    {
        UserOutputModel FindUsers(UserInputModel inputModel);
    }
}
