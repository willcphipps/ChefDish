using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChefDish.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChefDish.Controllers {
    public class HomeController : Controller {
        private MyContext _context { get; set; }

        public HomeController (MyContext context) {
            _context = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpGet ("Dishes")]
        public IActionResult Dishes () {
            return View ("Dishes");
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
                return Redirect ("Index");
            } else {
                return View ("AddChef");
            }
        }

        [HttpGet ("AddDish")]
        public IActionResult AddDish () {
            return View ();
        }

        [HttpPost ("CreateDish")]
        public IActionResult CreateDish (Dish plato) {
            if (ModelState.IsValid) {
                _context.LosPlatos.Add (plato);
                _context.SaveChanges ();
                return Redirect ("Dishes");
            } else {
                return View ("AddDish");
            }
        }
    }
}