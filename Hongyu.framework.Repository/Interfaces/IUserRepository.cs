using Hongyu.framework.Common.IDependencies;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
namespace Hongyu.framework.Repository.Interfaces
{
    public interface IUserRepository : IDependency
    {
        UserOutputModel FindUsers(UserInputModel inputModel);
    }
}
