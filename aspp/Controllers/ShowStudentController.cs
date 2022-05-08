using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspp.Services;

namespace aspp.Controllers
{
    public class ShowStudentController : Controller
    {
        private IRepository _repo;

        public ShowStudentController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult GetStudent(int id)
        {
            return View(_repo.Get(id));
        }
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
