using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspp.Services;

namespace aspp.Controllers
{
    public class ShowStudentsController : Controller
    {

        private IRepository repository;

        public ShowStudentsController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }


        [HttpPost]
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");

        }
    }
}
