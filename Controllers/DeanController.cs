using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBU_SYSTEM.Controllers
{
    public class DeanController : Controller
    {
        public IActionResult Course()
        {
            return View();
        }
        public ActionResult Learner()
        {
            return View();
        }
        public ActionResult Mark()
        {
            return View();
        }
        public ActionResult PracticumMark()
        {
            return View();
        }

        public ActionResult ReExamMark()
        {
            return View();
        }
        public ActionResult ReStudyMark()
        {
            return View();
        }
        public ActionResult ThesisMark()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
    }
}

