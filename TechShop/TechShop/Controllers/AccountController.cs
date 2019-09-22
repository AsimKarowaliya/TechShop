using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TechShop.Models;

namespace TechShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, false);


                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }


                ModelState.AddModelError("", "Invalid Login Attempt");

                return View(login);
            }

            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUp users)
        {
            if (!ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = users.Email, Email = users.Email };
                var result = await _userManager.CreateAsync(user, users.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }
            }
            return View(users);
        }
    }
}