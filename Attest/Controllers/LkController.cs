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
        public async Task<IActionResult> Lk(SortState sortOrder = SortState.NomZayavAsc)
        {


            var Email = HttpContext.User.Identity.Name;
            Users user = db.Users.Where(p => p.Email == Email).First();

            //CompositeModel compositeModel=new CompositeModel(db);

            try
            {
                if (user.role == "1")
                {
                    ViewBag.LK = db.Zayavlen.Where(p => p.id_user == user.Id).OrderByDescending(p => p.data_podachi)
                        .ToList();

                    return View("user");
                }

                if (user.role == "2")
                {




                    var listotv = new ListOtv();
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
                                                  dolgnost = zaya.dolgnost_att,
                                                  kategor = zaya.kategor,
                                                  file = (x == null ? String.Empty : x.name_f),
                                                  status = zaya.status
                                              }).ToList();
                    return View("otv", listotv);





                }




                if (user.role == "3")
                {




                    var listotv = new ListOtv();
                    listotv.ListOtvetstven =
                        (from zaya in db.Zayavlen.Where(p => p.spec == user.Id && p.status == "Заявление подлинное" || p.status == "Анализ проведен")
                         join usr in db.Users on zaya.id_user equals usr.Id
                         select new Otvetstven
                         {
                             Id = zaya.Id,
                             name = usr.FIO,
                             data_podachi = zaya.data_podachi,
                             oo = zaya.oo,
                             dolgnost = zaya.dolgnost_att,
                             kategor = zaya.kategor,
                             ball = zaya.ball,
                             status = zaya.status
                         }).ToList();
                    return View("spec", listotv);






                }
                if (user.role == "4")
                {


                    var listotv = new ListOtv();
                    listotv.ListOtvetstven = (from zaya in db.Zayavlen
                                              join usr in db.Users on zaya.id_user equals usr.Id
                                              join spec1 in db.Users on zaya.spec equals spec1.Id into gi
                                              from spec in gi.DefaultIfEmpty()
                                              join mo in db.Mo on zaya.mo equals mo.Id into mun
                                              from m in mun.DefaultIfEmpty()
                                              join fl in db.File.Where(p => p.kategor_f == "PrevAttestCopy") on zaya.Id equals fl.id_zayavl into gj
                                              from x in gj.DefaultIfEmpty()
                                              select new Otvetstven
                                              {
                                                  Id = zaya.Id,
                                                  name = usr.FIO,
                                                  data_podachi = zaya.data_podachi,
                                                  mo = (m== null ? String.Empty : m.name),
                                                  oo = zaya.oo,
                                                  dolgnost = zaya.dolgnost_imeyu,
                                                  narp_po_dolg = zaya.uch_stepen,
                                                  kategor = zaya.kategor,
                                                  status = zaya.status,
                                                  file = (x == null ? String.Empty : x.name_f),
                                                  spec = (spec.FIO == null ? String.Empty : spec.FIO)


                                              }).ToList();
                    listotv.data_nachalo = "3.06.2019";
                    return View("att", listotv);

                }

                }
            catch
            {

            }

           



                       return View("index");

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



        public async Task<IActionResult> Sort(SortState sortOrder, ListOtv att)
        {
       
          


            var listotv = new ListOtv();
            var query = (from zaya in db.Zayavlen
                         join usr in db.Users on zaya.id_user equals usr.Id
                         join spec1 in db.Users on zaya.spec equals spec1.Id into gi
                         from spec in gi.DefaultIfEmpty()
                         join mo in db.Mo on zaya.mo equals mo.Id into mun
                         from m in mun.DefaultIfEmpty()
                         join fl in db.File.Where(p => p.kategor_f == "PrevAttestCopy") on zaya.Id equals fl.id_zayavl into gj
                         from x in gj.DefaultIfEmpty()
                         select new Otvetstven
                         {
                             Id = zaya.Id,
                             name = usr.FIO,
                             data_podachi = zaya.data_podachi,
                             mo = (m == null ? String.Empty : m.name),
                             oo = zaya.oo,
                             dolgnost = zaya.dolgnost_imeyu,
                             narp_po_dolg = zaya.uch_stepen,
                             kategor = zaya.kategor,
                             status = zaya.status,
                             file = (x == null ? String.Empty : x.name_f),
                             spec = (spec.FIO == null ? String.Empty : spec.FIO)


                         });

          if(att.data_nachalo!=null && att.data_konec!=null)
                 query = query.Where(p => p.data_podachi>=Convert.ToDateTime(att.data_nachalo) && p.data_podachi <= Convert.ToDateTime(att.data_konec));
            
        if (att.dolg != null)
            {
              query=query.Where(p => p.dolgnost == att.dolg);
            }
            if (att.napr_po_dolg != null )
            {
                query = query.Where(p => p.narp_po_dolg == att.napr_po_dolg);
            }
            if (att.dolg != null && att.dolg!="учитель")
            {
              query=query.Where(p => p.dolgnost == att.dolg );
            }
            if (att.FIO != null)
            {
                query = from t in query
                         where t.name.Contains(att.FIO)
                        select t;

            }
            if (att.specFIO != null)
            {
                query = from t in query
                        where t.spec.Contains(att.specFIO)
                        select t;
            }






            ViewData["NomZayav"] = sortOrder == SortState.NomZayavAsc ? SortState.NomZayavDesc : SortState.NomZayavAsc;


            ViewData["Name"] = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;


            ViewData["DataPodach"] = sortOrder == SortState.DataPodachAsc ? SortState.DataPodachDesc : SortState.DataPodachAsc;


            ViewData["Mo"] = sortOrder == SortState.MoAsc ? SortState.MoDesc : SortState.MoAsc;


            ViewData["Status"] = sortOrder == SortState.StatusAsc ? SortState.StatusDesc : SortState.StatusAsc;


            ViewData["Spec"] = sortOrder == SortState.SpecAsc ? SortState.SpecDesc : SortState.SpecAsc;


            ViewData["Bal"] = sortOrder == SortState.BalAsc ? SortState.BalDesc : SortState.BalAsc;










            switch (sortOrder)
            {
               /* case "1":
                    listotv.ListOtvetstven = query.OrderBy(s => s.Id).ToList();
                    break;*/


                case SortState.NomZayavAsc:
                     listotv.ListOtvetstven = query.OrderBy(s => s.Id).ToList();
                    break;
                case SortState.NomZayavDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.Id).ToList();
                    break;
                case SortState.NameAsc:
                     listotv.ListOtvetstven  = query.OrderBy(s => s.name).ToList();
                    break;
                case SortState.NameDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.name).ToList();
                    break;
                case SortState.DataPodachAsc:
                     listotv.ListOtvetstven = query.OrderBy(s => s.data_podachi).ToList();
                    break;

                case SortState.DataPodachDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.data_podachi).ToList();
                    break;
                case SortState.MoAsc:
                     listotv.ListOtvetstven = query.OrderBy(s => s.mo).ToList();
                    break;
                case SortState.MoDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.mo).ToList();
                    break;
                case SortState.StatusAsc:
                     listotv.ListOtvetstven = query.OrderBy(s => s.status).ToList();
                    break;
                case SortState.StatusDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.status).ToList();
                    break;

                case SortState.SpecAsc:
                     listotv.ListOtvetstven = query.OrderBy(s => s.spec).ToList();
                    break;
                case SortState.SpecDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.spec).ToList();
                    break;
                case SortState.BalAsc:
                     listotv.ListOtvetstven = query.OrderBy(s => s.ball).ToList();
                    break;
                case SortState.BalDesc:
                     listotv.ListOtvetstven = query.OrderByDescending(s => s.ball).ToList();
                    break;
               
                /*default:
                     listotv.ListOtvetstven = query.OrderBy(s => s.Id).ToList();
                    break;
                    */



            }
            listotv.data_nachalo = att.data_nachalo;
            listotv.data_konec = att.data_konec;
            listotv.dolg = att.dolg;
            listotv.FIO = att.FIO;
            listotv.napr_po_dolg = att.napr_po_dolg;
            listotv.specFIO = att.specFIO;

            return View("att",listotv);
        }




    }
}
