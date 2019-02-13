using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Attest.Models;

namespace Attest.Controllers
{
    public class UserController : Controller
    {

        private DataContext db = new DataContext();
       

     
        public IActionResult User(int id)
        {
            ViewBag.User = db.Users.ToList();
            return View();
        }

        [HttpGet]
    
        public IActionResult view(int id,Users users)
        {

            return View("View",db.Users.Find(id));
        }

      
        [HttpGet]
        [Route("red")]
        public IActionResult red(int id)
        {
            return RedirectToAction("Edit",new{id});
           
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.Users.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Users users)
        {
            db.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("User");
        }
    }
}