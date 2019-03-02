using Attest.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using ServiceReference2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Attest.Controllers
{
    public class UserController : Controller
    {
        DataContext _context;
        IHostingEnvironment _appEnvironment;

        private DataContext db = new DataContext();



        public IActionResult User(int id)
        {
            ViewBag.User = db.Users.ToList();
            return View();
        }

        public async Task<IActionResult> Update(int id)
        {
            StaffPortfolioServiceClient client = new StaffPortfolioServiceClient();

            string snils = "00812870630";
            //02332960826     15234126527  12962899413
            var nameUser = client.GetStaffInfoBySnilsAsync(snils).Result.staffPortfolio;

            Users users = new Users();
            users.Id = 5;
            users.FIO = nameUser.PersonData.FirstName + " " + nameUser.PersonData.MiddleName + " " + nameUser.PersonData.LastName;
            // users.FIO = nameUser.OrganizationData.Municipality;
            db.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            Obrazovan obraz = new Obrazovan();
            obraz.id_zayavl = 3;

            for (int i = 0; i < nameUser.EducationData.Length; i++)
            {
                obraz.id_zayavl = 1;
                obraz.tip_obr = 1;
                obraz.oo = nameUser.EducationData[i].Organization;
                obraz.mo = nameUser.EducationData[i].Municipality;
                obraz.period = nameUser.EducationData[i].Period.Start + " - " + nameUser.EducationData[i].Period.End;
                obraz.special = nameUser.EducationData[i].Speciality;
                obraz.kvalif = nameUser.EducationData[i].Qualification;
                obraz.nazv_doc = nameUser.EducationData[i].CompletionDocument.DocType.Value.ToString();
                obraz.ser_doc = nameUser.EducationData[i].CompletionDocument.Series;
                obraz.nom_doc = nameUser.EducationData[i].CompletionDocument.Number;
                obraz.data_doc = Convert.ToDateTime(nameUser.EducationData[i].CompletionDocument.IssueDate);
                obraz.reg_nom = nameUser.EducationData[i].CompletionDocument.RegNumber;


            }

            for (int i = 0; i < nameUser.StaffTrainingsData.Length; i++)
            {
                obraz.id_zayavl = 1;
                obraz.tip_obr = 2;
                obraz.oo = nameUser.StaffTrainingsData[i].Organization;
                obraz.mo = nameUser.StaffTrainingsData[i].Place;
                obraz.kol_chas = nameUser.StaffTrainingsData[i].Hours.ToString();
                obraz.period = nameUser.StaffTrainingsData[i].Period.Start + " - " + nameUser.StaffTrainingsData[i].Period.End;
                obraz.special = nameUser.StaffTrainingsData[i].Theme;
                obraz.kvalif = nameUser.StaffTrainingsData[i].Form.ToString();
                obraz.nazv_doc = nameUser.StaffTrainingsData[i].CompletionDocument.DocName;
                obraz.ser_doc = nameUser.StaffTrainingsData[i].CompletionDocument.Series;
                obraz.nom_doc = nameUser.StaffTrainingsData[i].CompletionDocument.Number;
                obraz.data_doc = Convert.ToDateTime(nameUser.StaffTrainingsData[i].CompletionDocument.IssueDate);
                obraz.reg_nom = nameUser.StaffTrainingsData[i].CompletionDocument.RegNumber;
                obraz.vid_obuch = nameUser.StaffTrainingsData[i].Level.ToString();


            }

            for (int i = 0; i < nameUser.StaffRetrainingsData.Length; i++)
            {
                obraz.id_zayavl = 1;
                obraz.tip_obr = 2;
                obraz.oo = nameUser.StaffRetrainingsData[i].Organization;
                obraz.mo = nameUser.StaffRetrainingsData[i].Place;
                obraz.kol_chas = nameUser.StaffRetrainingsData[i].Hours.ToString();
                obraz.period = nameUser.StaffRetrainingsData[i].Period.Start + " - " + nameUser.StaffRetrainingsData[i].Period.End;
                obraz.special = nameUser.StaffRetrainingsData[i].Speciality;
                obraz.kvalif = nameUser.StaffRetrainingsData[i].Qualification;
                obraz.nazv_doc = nameUser.StaffRetrainingsData[i].CompletionDocument.DocName;
                obraz.ser_doc = nameUser.StaffRetrainingsData[i].CompletionDocument.Series;
                obraz.nom_doc = nameUser.StaffRetrainingsData[i].CompletionDocument.Number;
                obraz.data_doc = Convert.ToDateTime(nameUser.StaffRetrainingsData[i].CompletionDocument.IssueDate);
                obraz.reg_nom = nameUser.StaffRetrainingsData[i].CompletionDocument.RegNumber;
                obraz.vid_obuch = nameUser.StaffRetrainingsData[i].RetrainingType.ToString();


            }

            db.Entry(obraz).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();

            Nauch_deyat nauch = new Nauch_deyat();
            for (int i = 0; i < nameUser.StaffMethodicalActivityData.Length; i++)
            {
                nauch.id_zayavl = 1;

                nauch.nazv = nameUser.StaffMethodicalActivityData[i].WorkName;
                nauch.nazv_p = nameUser.StaffMethodicalActivityData[i].ProductName;
                nauch.urov = nameUser.StaffMethodicalActivityData[i].Level.ToString();
                nauch.period = nameUser.StaffMethodicalActivityData[i].Period.Start + " - " + nameUser.StaffMethodicalActivityData[i].Period.End;
                nauch.status = nameUser.StaffMethodicalActivityData[i].Participation.ToString();
                nauch.realiz = nameUser.StaffMethodicalActivityData[i].ImplementedIn;
                nauch.el_adr = nameUser.StaffMethodicalActivityData[i].HostingAddress;




            }
            db.Entry(nauch).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();



            for (int i = 0; i < nameUser.StaffPortfolioFilesData.Length; i++)
            {
                FileModel file = new FileModel();
                file.id_zayavl = 1;

                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/wwwroot/Files/" + file.id_zayavl);

                string path = Directory.GetCurrentDirectory() + "/wwwroot/Files/" + file.id_zayavl + "/" + nameUser.StaffPortfolioFilesData[i].OriginalFileName;
                file.name_f = nameUser.StaffPortfolioFilesData[i].OriginalFileName;
                byte[] f;
                f = nameUser.StaffPortfolioFilesData[i].File;

                var file1 = new FileInfo(@".\Test.txt");

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    stream.Write(nameUser.StaffPortfolioFilesData[i].File, 0, nameUser.StaffPortfolioFilesData[i].File.Length);
                }
                // FileStream stream = new FileStream(path,FileMode.Create);
                using (FileStream s = System.IO.File.Create(path))
                {
                    await s.WriteAsync(nameUser.StaffPortfolioFilesData[i].File);
                }







                //   file.nazv_p = nameUser.StaffPortfolioFilesData[i].;
                file.kategor_f = nameUser.StaffPortfolioFilesData[i].FileCategory.ToString();

                db.Entry(file).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                db.SaveChanges();


            }




            for (int i = 0; i < nameUser.AcademicAwardsData.Length; i++)
            {
                nauch.id_zayavl = 1;

                nauch.nazv = nameUser.AcademicAwardsData[i].AcademicDegree;
                nauch.nazv_p = nameUser.AcademicAwardsData[i].AcademicTitle;
                nauch.urov = nameUser.AcademicAwardsData[i].Speciality;
                nauch.urov = nameUser.AcademicAwardsData[i].AwardDocument.Number;
                /*   nauch.period = nameUser.AcademicAwardsData[i].Period.Start + " - " + nameUser.StaffMethodicalActivityData[i].Period.End;
                   nauch.status = nameUser.StaffMethodicalActivityData[i].Participation.ToString();
                   nauch.realiz = nameUser.StaffMethodicalActivityData[i].ImplementedIn;
                   nauch.el_adr = nameUser.StaffMethodicalActivityData[i].HostingAddress;*/




            }
            /*   db.Entry(nauch).State = Microsoft.EntityFrameworkCore.EntityState.Added;
               db.SaveChanges();
               /*var a = client.GetStaffInfoBySnils(Snils: snils).OrganizationData.Email;
               var b = client.GetStaffInfoBySnils(Snils: snils).MainPosition.AttestDate;*/
            return View();
        }

        public void SGO()
        {
            StaffPortfolioServiceClient client = new StaffPortfolioServiceClient();

            string snils = "01696788202";
            //02332960826     15234126527  12962899413
            var nameUser = client.GetStaffInfoBySnilsAsync(snils).Result.staffPortfolio.PersonData.FirstName;
            Users users = new Users();
            users.Id = 1;
            users.FIO = nameUser;
            db.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            /*var a = client.GetStaffInfoBySnils(Snils: snils).OrganizationData.Email;
            var b = client.GetStaffInfoBySnils(Snils: snils).MainPosition.AttestDate;*/

        }

        [HttpGet]

        public IActionResult view(int id, Users users)
        {

            return View("View", db.Users.Find(id));
        }


        [HttpGet]
        [Route("red")]
        public IActionResult red(int id)
        {
            return RedirectToAction("Edit", new { id });

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






        //[HttpGet]
        //[Route("zayav/{id_user}")]
        //public IActionResult Zayav(int id_user)
        //{

        //    return View("ZayavEdit", db.Zayavlen.Find(id_user));
        //}

        //  [HttpPost]
        [Route("zayav/{id}")]
        public IActionResult Zayav(int id)
        {
            ViewBag.User = db.Zayavlen.Where(p => p.Id == id).ToList();
            return View("ZayavEdit", db.Zayavlen.Find(id));
            /*
            db.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("User");*/
        }

        public IActionResult ZayavSaveEdit(int id_user, Zayavlen zayav)
        {

            db.Entry(zayav).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Lk", "Lk");
        }
    }
}