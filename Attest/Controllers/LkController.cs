using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Attest.Models;

namespace Attest.Controllers
{
    public class LkController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Lk()
        {
            /* ViewBag.LK = db.Zayavlen.Where(p=>p.id_user==1).ToList();
             return View("Lk-user");*/
             ViewBag.LK = db.Zayavlen.Where(p=>p.mo==1).ToList();
           return View("otv");
        }
    }
}