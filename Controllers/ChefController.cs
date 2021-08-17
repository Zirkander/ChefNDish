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
    public class ChefController : Controller
    {

        private ChefNDishContext db;

        public ChefController(ChefNDishContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            List<Chef> allChefs = db.Chefs
            .Include(c => c.CreatedDishes)
            .ToList();
            return View("Index", allChefs);
        }

        // [HttpGet("/all")]

        [HttpGet("/chef/new")]
        public IActionResult NewChef()
        {
            return View("NewChef");
        }

        [HttpPost("/chef/Add")]
        public IActionResult AddChef(Chef newChef)
        {
            // if (ModelState.IsValid == false)
            // {
            //     return RedirectToAction("NewChef");
            // }
            db.Add(newChef);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
