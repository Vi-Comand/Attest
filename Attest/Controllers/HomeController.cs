using Attest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attest.Controllers
{

    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult login()
        {
            ViewBag.User = db.Users.ToList();
            return View();
        }

        public IActionResult Index()
        {

            return View("index");
        }
        public async Task<IActionResult> Auto(string Email, string pass)
        {



            Users user = await db.Users.FirstOrDefaultAsync(p => p.Email == Email);
            if (user != null && user.pass == pass)
                return Redirect(Url.Action("View/" + user.Id, "User"));

            return View("ненорм");
        }
    }
}