﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Register")]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            User user = new User
            {
                Fullname = register.Fullname,
                UserName = register.Username,
                Email = register.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(user, Helpers.Extensions.Role.User.ToString());
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Login")]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);
            User user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Email or Password is incorrect!!!");
                return View(login);
            }
            if (user.Deleted == true)
            {
                ModelState.AddModelError(string.Empty, "This user has been deleted");
                return View(login);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, login.Password, false, true); 

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Email or Password is incorrect!!!");
                return View(login);
            }
            
            return RedirectToAction("Index", "Home");
        }

        public async Task CreateRole()
        {
            if (!await _roleManager.RoleExistsAsync(Helpers.Extensions.Role.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Extensions.Role.Admin.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Helpers.Extensions.Role.User.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Extensions.Role.User.ToString()));
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}