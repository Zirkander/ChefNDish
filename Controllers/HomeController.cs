using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefNDish.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefNDish.Controllers
{
    public class HomeController : Controller
    {

        private ChefNDishContext dbContext;

        public HomeController(ChefNDishContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("AddChef")]
        public IActionResult AddChef(Chef newChef)
        {
            DbContext.Add(newChef);
            ViewBag.Chef = newChef;
            dbContext.SaveChanges();
            return View("newChef", newChef);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
