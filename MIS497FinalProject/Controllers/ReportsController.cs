using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIS497FinalProject.Models;

namespace MIS497FinalProject.Controllers
{
    public class ReportsController : Controller
    {
        Reports countReport = new Reports();
        // GET: Reports
        private ApplicationDbContext _context;
        
        public ReportsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult Reports()
        {
            var usersCount = _context.Users.Count();
            countReport.userCount = usersCount;
            ViewBag.ShowCountReport = countReport.userCount;
            return View();
        }

        //public ActionResult Reports()
        //{
            
        //    return View();
        //}
    }
}