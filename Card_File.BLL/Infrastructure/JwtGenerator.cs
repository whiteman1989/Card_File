using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Card_File.BLL.Interfaces;
using Card_File.DAL.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Card_File.BLL.Infrastructure
{
	public class JwtGenerator : IJwtGenerator
	{
		private readonly SymmetricSecurityKey _key;

		public JwtGenerator(IConfiguration config)
		{
			_key = AuthOption.GetSecurityKey(config["AuthOptions:Key"]);
		}
		
		public string CreateToken(ApplicationUser user, IEnumerable<string> roles)
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id),
			};

			if (roles != null && roles.Any())
			{
				foreach (var role in roles)
				{
					claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role));
				}
			}
			else
			{
				claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, "role"));
			}

			ClaimsIdentity identity = new ClaimsIdentity(claims, "Token",
				ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

			var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);
			var jwt = new JwtSecurityToken(
				issuer: AuthOption.ISSUER,
				audience: AuthOption.AUDIENCE,
				notBefore: DateTime.UtcNow,
				claims: identity.Claims,
				expires: DateTime.UtcNow.AddMinutes(AuthOption.LIFETIME),
				signingCredentials: credentials
			);
			return new JwtSecurityTokenHandler().WriteToken(jwt);
		}
		

	}
}