using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspp.Models;
using aspp.Services;

namespace aspp.Controllers
{
    public class RegisterController : Controller
    {
        private IRepository repository;

        public RegisterController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            StudentViewModel userViewModel = new StudentViewModel()
            {
                Student = new Entities.Student()
            };
            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult Add(StudentViewModel userViewModel)
        {
            repository.Add(userViewModel.Student);


            return RedirectToAction("Index", "Home");
        }
    }
}
