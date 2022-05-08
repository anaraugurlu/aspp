using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspp.Services;

namespace aspp.Controllers
{
    public class DeleteController : Controller
    {
        private IRepository repository;


        public int id = 0;
        public DeleteController(IRepository repository)
        {
            this.repository = repository;
        }


        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Remove(int id)
        {

            repository.Delete(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
