using Hongyu.framework.Common.Log;
using Hongyu.framework.IServices;
using Hongyu.framework.Models.Input;
using Hongyu.framework.Models.Output;
using Microsoft.AspNetCore.Mvc;

namespace Hongyu.framework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService; 
        private readonly ILogHelper _logHelper;
        public UserController(IUserService userService,ILogHelper logHelper)
        {
            _userService = userService;
            _logHelper = logHelper;
        }
        [HttpPost(Name = "FindUserList")]
        public IActionResult FindUserList(UserInputModel inputModel)
        {
            UserOutputModel outputmodel = _userService.FindUserList(inputModel);
            return Ok();
        }

        [HttpGet]
        [Route("FindUserInfo")]
        public int FindUserInfo(int Id)
        {
            _logHelper.Info("1234");
            return Id;
        }
    }
}
