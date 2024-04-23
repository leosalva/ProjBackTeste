using Microsoft.AspNetCore.Mvc;
using ProjBackTeste.Application.Interface;


namespace ProjBackTeste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUser")]
        public IActionResult Get()
        {
            string user = _userService.GetUser();
            return Ok(user);
        }


        [HttpPost("CreateUser")]
        public IActionResult Post()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("DeleteUser/{user}")]
        public IActionResult Delete(string user)
        {
            throw new NotImplementedException();
        }

        [HttpPut("UpdateUser")]
        public IActionResult Put()
        {
            throw new NotImplementedException();
        }
    }
}
