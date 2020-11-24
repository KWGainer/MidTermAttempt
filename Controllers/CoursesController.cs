using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidTerm.Models;

namespace MidTerm.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Courses()
        {
            //return View();
            return Content("Hello World");
        }
    }
}