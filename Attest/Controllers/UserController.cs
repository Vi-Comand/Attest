using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Attest.Models;

namespace Attest.Controllers
{[Route("user")]
    public class UserController : Controller
    {

        private DataContext db = new DataContext();
        [Route("")]
        [Route("index")]
        [Route("~/")]

        public IActionResult Index()
        {
            ViewBag.User = db.User.ToList();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {

            return View("Add");
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.User.Remove(db.User.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.User.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, User user)
        {
            db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}