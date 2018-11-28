using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MIS497FinalProject.Models;

namespace MIS497FinalProject.Controllers
{
    public class UserFoodController : Controller
    {
        // GET: UserFOod

        private ApplicationDbContext _context;

        public UserFoodController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult UserFood()
        {
            var food = _context.UserFood.ToList();
            return View(food);
        }

        public ActionResult New()
        {
            //var userFoods = _context.UserFood.ToList();
            var Model = new addFoodViewModel
            {
                //newFood = userFoods
            };
            return View("UserFoodForm", Model);
        }
        [HttpPost]
        public ActionResult Save(UserFood userFood)
        {
            if (userFood.ID == 0)
                _context.UserFood.Add(userFood);
            else
            {
                var foodInDB = _context.UserFood.Single(c => c.ID == userFood.ID);
                foodInDB.FoodName = userFood.FoodName;
                //foodInDB.userID = ;
                foodInDB.Calories = userFood.Calories;
                foodInDB.Protein = userFood.Protein;
                foodInDB.Fat = userFood.Fat;
                foodInDB.Carbs = userFood.Carbs;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "UserFood");
        }

        public ViewResult Index()
        {
            var userFood = _context.UserFood.Include(c => c.FoodName).ToList();
            return View(userFood);
        }

        public ActionResult Edit(int id)
        {
            var userFood = _context.UserFood.SingleOrDefault(c => c.ID == id);

            if (userFood == null)
                return HttpNotFound();

            var Model = new addFoodViewModel
            {
                newFood = userFood
            };
            return View("CustomerForm", Model);
        }
    }
}

