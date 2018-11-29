using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIS497FinalProject.Models;

namespace MIS497FinalProject.Controllers
{

    public class LogController : Controller
    {
        // GET: Log

        //[Route("log/date/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult Index()
        //{
        //    var log = new Log();
        //    return View(log);
        //}
        private ApplicationDbContext _context;

        public LogController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Submit)
        {
            //var log = _context.Log.Include(d => d.Logate);

            //if (!String.IsNullOrEmpty(Submit))
            //{
            //    DateTime search_date = Convert.ToDateTime(Submit);
            //    log = log.Where(r => r.LogDate == search_date);
            //}
            //return View(log.ToList());

            //ViewBag.Message = "Selected Date: " + selectedDate;
            return View();
        }


    }
}