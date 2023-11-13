using Hongyu.framework.Common.IDependencies;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
namespace Hongyu.framework.Application.Interfaces
{
    public interface IUserService : IScopeDependency
    {
        public UserOutputModel FindUserList(UserInputModel inputModel);
    }
}
