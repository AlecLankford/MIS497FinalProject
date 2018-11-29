using System;
using System.Collections.Generic;
using System.Data.Entity; 
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIS497FinalProject.Models;

namespace MIS497FinalProject.Controllers
{
    public class GraphsController : Controller
    {
        // GET: Graphs

        private ApplicationDbContext _context;
        public GraphsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ActionResult Graphs()
        {
            var fList = _context.Food.ToList();
            int fCount = fList.Count();
            
            //nutritionalChart data
            var fatTotal = _context.Food.Sum(f => f.Fat);
            ViewBag.FatTotal = fatTotal;

            var proteinTotal = _context.Food.Sum(p => p.Protein);
            ViewBag.ProteinTotal = proteinTotal;

            var carbTotal = _context.Food.Sum(c => c.Carbs);
            ViewBag.CarbTotal = carbTotal;


            //calorieChart data


            var nameArr = _context.Food.Select(f => f.FoodName).ToArray();
            var calArr = _context.Food.Select(c => c.Calories).ToArray();
            ViewBag.NameData = nameArr;
            ViewBag.CalData = calArr;

            //String[,] calChartArr = new string[nameArr.Length, calArr.Length];

            //for (int i = 0; i > 0; i++)
            //{
            //    foreach (string name in nameArr)
            //    {
            //        calChartArr[i, 0] = name;
            //    }
            //}

            //for (int i = 0; i > 0; i++)
            //{
            //    foreach (double calorieRecord in calArr)
            //    {
            //        calChartArr[0, i] = calorieRecord.ToString();
            //    }
            
            return View();
        }
    }
}