using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using MIS497FinalProject.Models;

namespace MIS497FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(string id)
        {
            //var userInfo = _context.Users.ToList().FirstOrDefault();
            //return View(userInfo);
            var userInfo = _context.Users.SingleOrDefault(c => c.Id == id);

            return View(userInfo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Food()
        {
            ViewBag.Message = "Your Food page.";

            return View();
        }

        public ActionResult Log()
        {
            ViewBag.Message = "Log";

            return View();
        }

        public ActionResult Reports()
        {
            ViewBag.Message = "Reports";
            return View();
        }
    }
}