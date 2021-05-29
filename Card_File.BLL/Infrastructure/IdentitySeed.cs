using System.Collections.Generic;
using System.Threading.Tasks;
using Card_File.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;

namespace Card_File.BLL.Infrastructure
{
	public static class IdentitySeed
	{
		public  static async  Task SeedDataAsync(UserManager<ApplicationUser> userManager,
			RoleManager<IdentityRole> roleManager, IConfiguration config)
		{
			List<string> roles = new List<string>
			{
				"admin",
				"user",
				"author"
			};
			
			foreach (var role in roles)
			{
				if (!(await roleManager.RoleExistsAsync(role)))
				{
					var t = roleManager.CreateAsync(new IdentityRole(role));
					t.Wait();
				}
			}

			string userName = config["SuperUser:name"];
			string email = config["SuperUser:email"];
			string password = config["SuperUser:password"];
			
			var user = new ApplicationUser
			{
				Email = email,
				UserName = userName
			};

			if (await userManager.FindByEmailAsync(user.Email) is null)
			{
				var result = await userManager.CreateAsync(user, password);
				if (result.Succeeded)
				{
					await userManager.AddToRoleAsync(user, "admin");
				}
			}
		}
	}
}