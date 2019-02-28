using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Attest.Models;
using Microsoft.AspNetCore.Authorization;

namespace Attest.Controllers
{
    public class LkController : Controller
    {
        private DataContext db = new DataContext();
        [Authorize]
        public IActionResult Lk(int id)
        {
             ViewBag.LK = db.Zayavlen.Where(p=>p.id_user==5).ToList();
             return View("user");
            /* ViewBag.LK = db.Zayavlen.Where(p=>p.mo==1).ToList();
           return View("otv");*/
          /*  ViewBag.LK = db.Zayavlen.Where(p => p.spec == 1).ToList();
            return View("spec");*/
        }
    }
}