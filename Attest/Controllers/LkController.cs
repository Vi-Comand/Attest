using Attest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Lk(SortState sortOrder = SortState.NomZayavAsc)
        {


            var Email = HttpContext.User.Identity.Name;
            Users user = db.Users.Where(p => p.Email == Email).First();
            ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_podachi).ToList();

            //CompositeModel compositeModel=new CompositeModel(db);
            return View("user");
            /* ViewBag.LK = db.Zayavlen.Where(p=>p.mo==1).ToList();
           return View("otv");*/
            /*  ViewBag.LK = db.Zayavlen.Where(p => p.spec == 1).ToList();
              return View("spec");*/
        }





        /*    ViewData["NomZayavSort"] = sortOrder == SortState.NomZayavAsc ? SortState.NomZayavDesc : SortState.NomZayavAsc;
            ViewData["DataPodachSort"] = sortOrder == SortState.DataPodachAsc ? SortState.DataPodachDesc : SortState.DataPodachAsc;
            ViewData["DataObnovSort"] = sortOrder == SortState.DataObnovAsc ? SortState.DataObnovDesc : SortState.DataObnovAsc;

            switch (sortOrder)
            {
                case SortState.NomZayavAsc:
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.Id).ToList();
                    break;
                case SortState.NomZayavDesc:
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.Id).ToList();
                    break;
                case SortState.DataPodachAsc:
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_podachi).ToList();
                    break;

                case SortState.DataObnovAsc:
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_obnovl).ToList();
                    break;
                case SortState.DataObnovDesc:
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_obnovl).ToList();
                    break;
                default:
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_podachi).ToList();
                    break;
            }
            //return View(await zayavlen.AsNoTracking().ToListAsync());
            */
    }
}
