using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            ViewBag.WelcomeString = "Hello world";
            var message = new MessageModel();
            message.welcome = "Chao mung ban den voi ASP.NET";
            return View(message);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}