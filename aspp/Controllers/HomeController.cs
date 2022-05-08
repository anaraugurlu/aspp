using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent()
        {
            return RedirectToAction("Index", "Register");
                
        }
        public IActionResult DeleteStudent()
        {
            return RedirectToAction("Index", "Delete");

        }

        public IActionResult UpdateStudent()
        {
            return RedirectToAction("Index", "Update");
        }

        public IActionResult ShowStudents()
        {
            return RedirectToAction("Index", "ShowStudents");

        }
        public IActionResult ShowStudent()
        {
            return RedirectToAction("Index", "ShowStudent");

        }
    }
}
