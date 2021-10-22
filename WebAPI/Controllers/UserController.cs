using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<DTO.User> Get()
        {
            return _userService.GetUsers();
        }

        [HttpPost]
        public ActionResult<DTO.User> Post(DTO.User user)
        {
            _userService.SetUser(user);
            return CreatedAtAction("SetUser", new { id = user.UserId }, user);
        }
    }
}
