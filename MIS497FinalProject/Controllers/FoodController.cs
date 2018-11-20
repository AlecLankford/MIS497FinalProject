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
        [Route("food")]
        public ActionResult Food()
        {
            var food = new Food() { foodName = "Foods" };
            return View(food);
        }
    }
}