using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIS497FinalProject.Models;

namespace MIS497FinalProject.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        private ApplicationDbContext _context;

        public FoodController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Food()
        {
            var food = _context.Food.ToList();
            return View(food);
        }

        public ActionResult InsertData()
        {
            return View();
        }
    }
}