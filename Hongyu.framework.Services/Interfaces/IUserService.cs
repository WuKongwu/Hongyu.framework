using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Hongyu.yu.framework.Extensions.Interfaces;

namespace Hongyu.framework.Application.Interfaces
{
    public interface IUserService : ITransientDependency
    {
        public UserOutputModel FindUserList(UserInputModel inputModel);
    }
}
