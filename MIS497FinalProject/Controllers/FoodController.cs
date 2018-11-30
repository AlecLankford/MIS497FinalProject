using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        //Function to insert a record from the food table
        public ActionResult InsertData()
        {
            return View();
        }

        //Function to insert a record from the food table
        [HttpPost]
         public ActionResult InsertData(Food food)
         {
             if (food.ID == 0)
                 _context.Food.Add(food);
             else
             {
                 var foodInDB = _context.Food.Single(c => c.ID == food.ID);
                 foodInDB.FoodName = food.FoodName;
                 foodInDB.Calories = food.Calories;
                 foodInDB.Protein = food.Protein;
                 foodInDB.Fat = food.Fat;
                 foodInDB.Carbs = food.Carbs;

             }
             _context.SaveChanges();

             return RedirectToAction("Food", "Food");
         }

        //Function to edit a record from the food table
        public ActionResult EditFood(string foodName)
        {
            var foodData = _context.Food.Where(x => x.FoodName == foodName).FirstOrDefault();
            if (foodData != null)
            {
                TempData["FoodName"] = foodName;
                TempData.Keep();
                return View(foodData);
            }
            return View();
        }

        //Function to edit a record from the food table
        [HttpPost] 
        public ActionResult EditFood(Food food)
        {
            Food temp = (Food)TempData["Food"];
            var FoodData = _context.Food.Where(x => x.ID == food.ID).FirstOrDefault();
            if (FoodData != null)
            {
                FoodData.FoodName = food.FoodName;
                FoodData.Calories = food.Calories;
                FoodData.Protein = food.Protein;
                FoodData.Fat = food.Fat;
                FoodData.Carbs = food.Carbs;
                _context.Entry(FoodData).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("Food");
        }

        //Function to delete a record from the food table
        public ActionResult DeleteFood(string foodName)
        {
            if (foodName != null)
            {
                var foodbyid = _context.Food.Where(x => x.FoodName == foodName).FirstOrDefault();
                if (foodbyid != null)
                {
                    _context.Entry(foodbyid).State = EntityState.Deleted;
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Food");
        }


        
        /*
        public ActionResult Submit()
        {
           //if (food.Selected == true) _context.FoodDTO.Add(food);

            var model = new FoodSelection();
            foreach (var f in _context.FoodDTO)
            {
                var editorViewModel = new FoodDTO()
                {
                    FoodName = f.FoodName,
                    Calories = f.Calories,
                    Protein = f.Protein,
                    Fat = f.Fat,
                    Selected = true
                };
                model.Food.Add(editorViewModel);
            }
            return View(model);
        }

        //////////////////////////////////////////

        [HttpPost]
        public ActionResult SubmitSelected(FoodSelection model)
        {
            // get the ids of the items selected:
            var selectedIds = model.getSelectedNames();

            // Use the ids to retrieve the records for the selected people
            // from the database:
            var selectedPeople = from x in _context.Food
                                 where selectedIds.Contains(x.FoodName)
                                 select x;

            // Process according to your requirements:
            foreach (var food in selectedPeople)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format("{0} {1}", food.FoodName, food.Calories));
            }

            // Redirect somewhere meaningful (probably to somewhere showing 
            // the results of your processing):
            return RedirectToAction("../Log/Index");
        }

        ////////////////////////////////////////////

        public ViewResult Index()
        {
            var food = _context.Food.Include(c => c.FoodName).ToList();
            return View(food);
        }

         public ActionResult Index()
         {
             var objStudentList = objContext.tbl_Students.ToList();
             return View(objStudentList);
         }*/
    }
}