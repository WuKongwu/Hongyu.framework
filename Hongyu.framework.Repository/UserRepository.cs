using Hongyu.framework.Models.Entitys;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Hongyu.framework.Repositories;
using Hongyu.framework.Repository.Interfaces;

namespace Hongyu.framework.Repository
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private readonly BaseRepository<UserEntity> _repository   ;
        public UserRepository() //:base(dbContext)
        {
            _repository = new BaseRepository<UserEntity>();
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
            var a = _repository.Select();
            return new UserOutputModel();
        }
    }
}
