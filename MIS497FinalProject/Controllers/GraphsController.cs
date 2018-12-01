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
            //nutritionalChart data
            var fatTotal = _context.Food.Sum(f => f.Fat);
            ViewBag.FatTotal = fatTotal;

            var proteinTotal = _context.Food.Sum(p => p.Protein);
            ViewBag.ProteinTotal = proteinTotal;

            var carbTotal = _context.Food.Sum(c => c.Carbs);
            ViewBag.CarbTotal = carbTotal;
            
            return View();
        }


        public ActionResult ReportsHome()
        {
            return View();
        }


        public ActionResult CalorieChart()
        {
            var fatTotal = _context.Food.Sum(f => f.Fat);
            ViewBag.bFatTotal = fatTotal;

            var proteinTotal = _context.Food.Sum(p => p.Protein);
            ViewBag.bProteinTotal = proteinTotal;

            var carbTotal = _context.Food.Sum(c => c.Carbs);
            ViewBag.bCarbTotal = carbTotal;

            return View();
        }

    }
}