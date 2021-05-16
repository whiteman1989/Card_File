using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Card_File.BLL.Infrastructure
{
    public static class AuthOption
    {
        public const string ISSUER = "CardFileServer";
        public const string AUDIENCE = "CardFileClient";
        const string KEY = "test_scretkey!567123";
        public const int LIFETIME = 10;
        public static SymmetricSecurityKey GetSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
