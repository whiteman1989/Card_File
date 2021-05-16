using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Card_File.BLL.Infrastructure;
using System.Threading.Tasks;

namespace Card_File.BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserSesion> LogInAsync(LoginQuery loginQuery);
        Task<UserSesion> RegisterAsync(RegisterQuery registerQuery);
    }
}
