using Attest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attest.Controllers
{
    public class LkController : Controller
    {
        private DataContext db = new DataContext();
        [Authorize]
        public IActionResult Lk()
        {


            var Email = HttpContext.User.Identity.Name;
            Users user = db.Users.Where(p => p.Email == Email).First();
            ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_podachi).ToList();

            return View("user");
            /* ViewBag.LK = db.Zayavlen.Where(p=>p.mo==1).ToList();
           return View("otv");*/
            /*  ViewBag.LK = db.Zayavlen.Where(p => p.spec == 1).ToList();
              return View("spec");*/
        }
    }
}