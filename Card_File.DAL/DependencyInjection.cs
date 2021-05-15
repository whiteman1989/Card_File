using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Card_File.DAL.EF;

namespace Card_File.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataServices (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                x => x.MigrationsAssembly("Card_File.DAL"))); //Runs migrations in DTO Assembly
            return services;
        }
    }
}
