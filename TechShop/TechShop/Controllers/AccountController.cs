using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechShop.Models;

namespace TechShop.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

             return View(login);
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}