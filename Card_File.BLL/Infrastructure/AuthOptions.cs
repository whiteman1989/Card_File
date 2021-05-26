using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;

namespace Card_File.BLL.Infrastructure
{
    public static class AuthOption
    {
        public const string ISSUER = "CardFileServer";
        public const string AUDIENCE = "CardFileClient";
        public const int LIFETIME = 200;

        public static SymmetricSecurityKey GetSecurityKey(string key)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        }
    }
}
