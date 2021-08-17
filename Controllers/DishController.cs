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
    public class DishController : Controller
    {

        private ChefNDishContext db;

        public DishController(ChefNDishContext context)
        {
            db = context;
        }

        [HttpGet("/dish")]
        public IActionResult Dishs()
        {
            List<Dish> allDishs = db.Dishs
            .Include(c => c.DishChef)
            .ToList();
            return View("Dishs", allDishs);
        }

        [HttpGet("/Dish/new")]
        public IActionResult NewDish()
        {
            List<Chef> allChef = db.Chefs.ToList();
            ViewBag.allChefs = allChef;
            return View("NewDish");
        }

        [HttpPost("/Dish/Add")]
        public IActionResult AddDish(Dish newDish)
        {
            // if (ModelState.IsValid == false)
            // {
            //     return RedirectToAction("NewDish");
            // }
            db.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
