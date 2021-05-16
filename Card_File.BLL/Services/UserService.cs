﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using Card_File.BLL.Interfaces;
using Card_File.BLL.Infrastructure;
using Card_File.DAL.Entities;
using Card_File.DAL.EF;

namespace Card_File.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationContext _context;
        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager, ApplicationContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }

        public async Task<UserSesion> LogInAsync(LoginQuery loginQuery)
        {
            var user = await _userManager.FindByEmailAsync(loginQuery.Email);
            if (user is object)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, loginQuery.Password, false);
                if(result.Succeeded)
                {
                    return new UserSesion
                    {
                        Email = user.Email,
                        Token = "assss"
                    };
                }
            }
            throw new ValidationException("Error login ot password", nameof(loginQuery));
        }

        public async Task<UserSesion> RegisterAsync(RegisterQuery registerQuery)
        {
            var user = new ApplicationUser
            {
                Email = registerQuery.Email,
                UserName = registerQuery.UserName,
            };
            var result = await _userManager.CreateAsync(user, registerQuery.Password);
            if(result.Succeeded)
            {
                return new UserSesion
                {
                    Email = user.Email,
                    Token = "bbbb",
                };
            }
            throw new ValidationException("User creation failed", nameof(registerQuery));
        }
    }
}