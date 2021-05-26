using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Card_File.BLL.Interfaces;
using Card_File.BLL.DTO;
using Card_File.BLL.Infrastructure;
using Microsoft.AspNetCore.Authorization;

namespace Card_File.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("logIn")]
        public async Task<ActionResult<UserSesion>> LogIn([FromBody] LoginQuery login)
        {
            var result = await _userService.LogInAsync(login);
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserSesion>> Register([FromBody] RegisterQuery registerQuery)
        {
            var result = await _userService.RegisterAsync(registerQuery);
            return Ok(result);
        }
        
        [HttpGet("currentId")]
        public async Task<ActionResult<string>> GetId()
        {
            var user = User.Identity.Name;
            return Ok(user);
        }
    }
}
