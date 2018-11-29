using System;
using System.Collections.Generic;
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
            
            return View();
        }
    }
}