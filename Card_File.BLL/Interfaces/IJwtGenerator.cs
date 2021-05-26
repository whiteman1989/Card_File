using System;
using System.Collections.Generic;
using System.Text;
using Card_File.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Card_File.BLL.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(ApplicationUser user, IEnumerable<string> roles);
    }
}
