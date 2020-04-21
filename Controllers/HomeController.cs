using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChefDish.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChefDish.Controllers {
    public class HomeController : Controller {
        private MyContext _context { get; set; }

        public HomeController (MyContext context) {
            _context = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            List<CatChef> AllChefs = _context.LosGatos.Include (p => p.Recipes).ToList ();
            return View (AllChefs);
        }

        [HttpGet ("Dishes")]
        public IActionResult Dishes () {
            List<Dish> AllDishes = _context.LosPlatos.Include (p => p.Creator).ToList ();
            return View (AllDishes);
        }

        [HttpGet ("AddChef")]
        public IActionResult AddChef () {
            return View ();
        }

        [HttpPost ("CreateCat")]
        public IActionResult CreateCat (CatChef gato) {
            if (ModelState.IsValid) {
                _context.LosGatos.Add (gato);
                _context.SaveChanges ();
                return RedirectToAction ("Index");
            } else {
                return View ();
            }
        }

        [HttpGet ("AddDish")]
        public IActionResult AddDish () {
            ViewBag.Cats = _context.LosGatos.Include (c => c.Recipes).ToList ();
            return View ();
        }

        [HttpGet ("destroy/{DId}")]
        public IActionResult destroydish (int DId) {
            Dish eightySixed = _context.LosPlatos.FirstOrDefault (l => l.DishId == DId);
            _context.LosPlatos.Remove (eightySixed);
            _context.SaveChanges ();
            return RedirectToAction ("Dishes");
        }

        [HttpPost ("CreateDish")]
        public IActionResult CreateDish (Dish plato) {
            if (ModelState.IsValid) {
                Console.WriteLine (plato);
                _context.LosPlatos.Add (plato);
                // plato.Creator = plato.ChefId;
                _context.SaveChanges ();
                return Redirect ("Dishes");
            } else {
                ViewBag.Cats = _context.LosGatos.Include (c => c.Recipes).ToList ();
                return View ("AddDish");
            }
        }
    }
}