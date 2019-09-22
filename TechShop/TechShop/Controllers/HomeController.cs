using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechShop.Models;

namespace TechShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseContext _db;
        public HomeController(DataBaseContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ICollection<Products> products = _db.Products.ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
