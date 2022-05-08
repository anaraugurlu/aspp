using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspp.Entities;
//using aspp.Helper;
using aspp.Services;
using Task3AspNet.Helper;
//using aspp.Helper;

namespace aspp.Controllers
{
    public class UpdateController : Controller
    {
        private IRepository _repo;

        public UpdateController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult UserFind1(int id)
        {
            StudentHelper.IdUpdate = id;
            return View(_repo.Get(id));
        }
        [HttpPost]
        public IActionResult UserFind(Student client)
        {
            _repo.Update(StudentHelper.IdUpdate, client);
            return RedirectToAction("Index", "Home");

        }
    }
}
