using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab25_New.Models;

namespace Lab25_New.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Form(FormResponse formResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", formResponse);
            }
            else
            {
                return View();
            }
        }
    }
}