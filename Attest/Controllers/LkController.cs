using Attest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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

            //CompositeModel compositeModel=new CompositeModel(db);


            if (user.role == "1")
            {
                 return View("user");
            }
            if (user.role == "2")
            {

                var comments =
                from n in db.Zayavlen.Where(p=>p.mo==user.mo)
                join f in db.Users
                on n.id_user
                equals f.Id
                select new { Zayavlen = n, user = f };
                ViewBag.users= comments;


                /*var compositeModel = new CompositeModel(db);
                compositeModel.Zayavlen = new Zayavlen();
               /* compositeModel.FileModel = new FileModel();
                compositeModel.Obrazovan = new Obrazovan();
                compositeModel.Nauch_Deyat = new Nauch_deyat();
                compositeModel.Users = new Users();
                compositeModel.ProfRazv = new ProfRazv();*/

                /*    compositeModel.listFile = db.File.Where(p => p.id_zayavl == id).ToList();
                    compositeModel.listObrazovan = db.Obrazovan.Where(p => p.id_zayavl == id).ToList();
                    compositeModel.listNauch_deyat = db.Naucn_deyat.Where(p => p.id_zayavl == id).ToList();
                    compositeModel.listProfRazv = db.ProfRazv.Where(p => p.id_zayav == id).ToList();*/
                /* compositeModel.ListZayavlen = db.Zayavlen.Where(p => p.mo ==user.mo).ToList();
                 compositeModel.ListUsers = db.Users.Join(db.Zayavlen,j=);*/
           
          
           var listotv=new ListOtv();
                listotv.ListOtvetstven = (from zaya in db.Zayavlen.Where(p => p.mo == user.mo)
                                          join usr in db.Users on zaya.id_user equals usr.Id
                                           join fl in db.File.Where(p => p.kategor_f == "PrevAttestCopy") on zaya.Id equals fl.id_zayavl 
                                       into gj
                                          from x in gj.DefaultIfEmpty() 
                                          select new Otvetstven
                                          {
                                              Id = zaya.Id,
                                              name = usr.FIO,
                                              data_podachi = zaya.data_podachi,
                                              oo = zaya.oo,
                                              dolgnost=zaya.dolgnost_att,
                                              kategor=zaya.kategor,
                                             file=(x==null? String.Empty:x.name_f),
                                             status=zaya.status
                           }).ToList();
                return View("otv", listotv);




                return View("otv",ViewBag.users);
            }
            return View("index");
            /* ViewBag.LK = db.Zayavlen.Where(p=>p.mo==1).ToList();
           return View("otv");*/
            /*  ViewBag.LK = db.Zayavlen.Where(p => p.spec == 1).ToList();
              return View("spec");*/
        }
    }
}