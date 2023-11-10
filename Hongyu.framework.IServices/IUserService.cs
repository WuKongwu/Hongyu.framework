using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Hongyu.yu.framework.Extensions.Interfaces;

namespace Hongyu.framework.IServices
{
    public interface IUserService : ITransientDependency
    {
        UserOutputModel FindUserList(UserInputModel inputModel);
    }
}
