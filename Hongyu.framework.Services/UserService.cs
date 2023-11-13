using Hongyu.framework.Application.Interfaces;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Hongyu.framework.Repository.Interfaces;

namespace Hongyu.framework.Application
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public UserOutputModel FindUserList(UserInputModel inputModel)
        {
             return _userRepository.FindUsers(inputModel);
        }

        //public UserOutputModel FindUserList(UserInputModel inputModel)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
