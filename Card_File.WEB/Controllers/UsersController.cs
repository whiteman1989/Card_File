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
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Card_File.WEB.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;
        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
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
            try
            {
                var result = await _userService.RegisterAsync(registerQuery);
                return Ok(result);
            }
            catch (ValidationException e)
            {
                _logger.LogInformation(e.Message);
                return BadRequest(e.Message);
            }
        }
        
        [Authorize]
        [HttpGet("currentId")]
        public ActionResult<string> GetId()
        {
            var user = $"id: {User.Identity.Name}";
            return Ok(user);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("isAdmin")]
        public ActionResult<string> IsAdmin()
        {
            return Ok("You are admin");
        }

        [Authorize(Roles = "admin")]
        [HttpGet("{name}/roles")]
        public async Task<ActionResult<IEnumerable<string>>> GetRoles(string name)
        {
            var roles = await _userService.GetRolesByNameAsync(name);
            return Ok(roles);
        }
    }
}
