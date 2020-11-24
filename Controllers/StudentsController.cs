using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidTerm.Models;

namespace MidTerm.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Students()
        {
            return View();
        }
    }
}