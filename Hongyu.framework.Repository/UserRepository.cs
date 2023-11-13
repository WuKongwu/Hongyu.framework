using Hongyu.framework.Models.Entitys;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Hongyu.framework.Repository.Interfaces;

namespace Hongyu.framework.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IRepository<UserEntity> _repository;
        public UserRepository(IRepository<UserEntity> repository)
        {
            _repository = repository;
        }

        //public UserOutputModel FindUsers(UserInputModel inputModel)
        //{
        //    var list = _repository.Select().Result;
        //    //var q = from li in list
        //    //        select new UserOutput()
        //    //        {
        //    //            Name = li.Name,
        //    //        };
        //    return new UserOutputModel {  } ;
        //}
        public UserOutputModel FindUsers(UserInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
