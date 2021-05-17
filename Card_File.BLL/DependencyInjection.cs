using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Card_File.DAL;
using Card_File.DAL.Entities;
using Card_File.DAL.EF;
using Microsoft.IdentityModel.Tokens;

namespace Card_File.BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataServices(configuration);

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

            return services;
        }
    }
}
