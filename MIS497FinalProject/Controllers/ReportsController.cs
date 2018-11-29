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
            
            return View();
        }
    }
}