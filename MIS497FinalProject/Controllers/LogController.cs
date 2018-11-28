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

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string selectedDate)
        {
            ViewBag.Message = "Selected Date: " + selectedDate;
            return View();
        }
    }
}