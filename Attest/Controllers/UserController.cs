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


        private DataContext db = new DataContext();



        public IActionResult User(int id)
        {
            ViewBag.User = db.Users.ToList();
            return View();
        }





        public async Task<IActionResult> Update(int id_user, int id, Users users)
        {

            StaffPortfolioServiceClient client = new StaffPortfolioServiceClient();

            string snils = db.Users.Find(id_user).Snils.ToString();
            //02332960826     15234126527  12962899413
            var nameUser = client.GetStaffInfoBySnilsAsync(snils).Result.staffPortfolio;
            users = db.Users.Find(id_user);


            users.FIO = nameUser.PersonData.FirstName + " " + nameUser.PersonData.MiddleName + " " + nameUser.PersonData.LastName;

            // users.FIO = nameUser.OrganizationData.Municipality;

            db.SaveChanges();
            // List<Obrazovan> obr = db.Obrazovan.Where(p => p.id_zayavl == id);


            Zayavlen zayav = db.Zayavlen.Find(id);
            // zayav.Id = id;
            zayav.id_user = id_user;
            zayav.data_last_att = Convert.ToDateTime(nameUser.MainPosition.AttestDate);
            zayav.data_obnovl = DateTime.Now;
            zayav.dolgnost_imeyu = nameUser.MainPosition.Position;
            zayav.kategor = nameUser.MainPosition.Category;
            zayav.kategor_rabot = nameUser.MainPosition.WorkerCategory;
            //  zayav.oo = nameUser.OrganizationData.Municipality;

            zayav.oo = nameUser.OrganizationData.ShortName;
            //zayav.uch_stepen
            // db.Set<Zayavlen>().Attach(zayav);
            //  db.Zayavlen.Update(zayav).;
            db.SaveChanges();
            var obr = db.Obrazovan.Where(w => w.id_zayavl == id);

            foreach (Obrazovan obrz in obr)
            {
                db.Obrazovan.Remove(obrz);
            }
            db.SaveChanges();
            // _context.Obrazovan.stRemoveRange(db.Obrazovan.Where(p => p.id_zayavl == id).ToList());
            //_context.SaveChanges();




            for (int i = 0; i < nameUser.EducationData.Length; i++)
            {
                Obrazovan obraz = new Obrazovan();
                obraz.id_zayavl = id;
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
                db.Entry(obraz).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();

            }

            for (int i = 0; i < nameUser.StaffTrainingsData.Length; i++)
            {
                Obrazovan obraz = new Obrazovan();
                obraz.id_zayavl = id;
                obraz.tip_obr = 2;
                obraz.oo = nameUser.StaffTrainingsData[i].Organization;
                obraz.mo = nameUser.StaffTrainingsData[i].Place;
                obraz.kol_chas = Convert.ToInt32(nameUser.StaffTrainingsData[i].Hours);
                obraz.period = nameUser.StaffTrainingsData[i].Period.Start + " - " + nameUser.StaffTrainingsData[i].Period.End;
                obraz.special = nameUser.StaffTrainingsData[i].Theme;
                obraz.kvalif = nameUser.StaffTrainingsData[i].Form.ToString();
                obraz.nazv_doc = nameUser.StaffTrainingsData[i].CompletionDocument.DocName;
                obraz.ser_doc = nameUser.StaffTrainingsData[i].CompletionDocument.Series;
                obraz.nom_doc = nameUser.StaffTrainingsData[i].CompletionDocument.Number;
                obraz.data_doc = Convert.ToDateTime(nameUser.StaffTrainingsData[i].CompletionDocument.IssueDate);
                obraz.reg_nom = nameUser.StaffTrainingsData[i].CompletionDocument.RegNumber;
                obraz.vid_obuch = nameUser.StaffTrainingsData[i].Level.ToString();
                db.Entry(obraz).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();

            }

            for (int i = 0; i < nameUser.StaffRetrainingsData.Length; i++)
            {
                Obrazovan obraz = new Obrazovan();
                obraz.id_zayavl = id;
                obraz.tip_obr = 2;
                obraz.oo = nameUser.StaffRetrainingsData[i].Organization;
                obraz.mo = nameUser.StaffRetrainingsData[i].Place;
                obraz.kol_chas = Convert.ToInt32(nameUser.StaffRetrainingsData[i].Hours);
                obraz.period = nameUser.StaffRetrainingsData[i].Period.Start + " - " + nameUser.StaffRetrainingsData[i].Period.End;
                obraz.special = nameUser.StaffRetrainingsData[i].Speciality;
                obraz.kvalif = nameUser.StaffRetrainingsData[i].Qualification;
                obraz.nazv_doc = nameUser.StaffRetrainingsData[i].CompletionDocument.DocName;
                obraz.ser_doc = nameUser.StaffRetrainingsData[i].CompletionDocument.Series;
                obraz.nom_doc = nameUser.StaffRetrainingsData[i].CompletionDocument.Number;
                obraz.data_doc = Convert.ToDateTime(nameUser.StaffRetrainingsData[i].CompletionDocument.IssueDate);
                obraz.reg_nom = nameUser.StaffRetrainingsData[i].CompletionDocument.RegNumber;
                obraz.vid_obuch = nameUser.StaffRetrainingsData[i].RetrainingType.ToString();
                db.Entry(obraz).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();

            }


            var nauc = db.Naucn_deyat.Where(w => w.id_zayavl == id);

            foreach (Nauch_deyat nauchn in nauc)
            {
                db.Naucn_deyat.Remove(nauchn);
            }
            db.SaveChanges();

            for (int i = 0; i < nameUser.StaffMethodicalActivityData.Length; i++)
            {
                Nauch_deyat nauch = new Nauch_deyat();
                nauch.id_zayavl = id;

                nauch.nazv = nameUser.StaffMethodicalActivityData[i].WorkName;
                nauch.nazv_p = nameUser.StaffMethodicalActivityData[i].ProductName;
                nauch.urov = nameUser.StaffMethodicalActivityData[i].Level.ToString();
                nauch.period = nameUser.StaffMethodicalActivityData[i].Period.Start + " - " + nameUser.StaffMethodicalActivityData[i].Period.End;
                nauch.status = nameUser.StaffMethodicalActivityData[i].Participation.ToString();
                nauch.realiz = nameUser.StaffMethodicalActivityData[i].ImplementedIn;
                nauch.el_adr = nameUser.StaffMethodicalActivityData[i].HostingAddress;


                db.Entry(nauch).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();


            }


            var prof = db.ProfRazv.Where(w => w.id_zayav == id);

            foreach (ProfRazv proff in prof)
            {
                db.ProfRazv.Remove(proff);
            }
            db.SaveChanges();

            for (int i = 0; i < nameUser.StaffMethodicalActivityData.Length; i++)
            {
                ProfRazv profr = new ProfRazv();
                profr.id_zayav = id;

                profr.uch_stepen = nameUser.AcademicAwardsData[i].AcademicDegree;
                profr.uch_zvanie = nameUser.AcademicAwardsData[i].AcademicTitle;
                profr.kod_nauc_spec = nameUser.AcademicAwardsData[i].Speciality;
                profr.nazv_doc = nameUser.AcademicAwardsData[i].AwardDocument.DocType.ToString();
                profr.org_d = nameUser.AcademicAwardsData[i].AwardDocument.Organization.ToString();
                profr.ser_d = nameUser.AcademicAwardsData[i].AwardDocument.Series.ToString();
                profr.non_d = nameUser.AcademicAwardsData[i].AwardDocument.Number.ToString();
                profr.data_vid_d = nameUser.AcademicAwardsData[i].AwardDocument.AwardDate;

                db.Entry(profr).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();


            }

            var fl = db.File.Where(w => w.id_zayavl == id);

            foreach (FileModel file in fl)
            {

                string path = Directory.GetCurrentDirectory() + "/wwwroot/Files/" + id + "/" + file.name_f;
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.Delete();
                    // альтернатива с помощью класса File
                    // File.Delete(path);
                }


                db.File.Remove(file);
            }
            db.SaveChanges();


            for (int i = 0; i < nameUser.StaffPortfolioFilesData.Length; i++)
            {
                FileModel file = new FileModel();
                file.id_zayavl = id;

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

                using (FileStream s = System.IO.File.Create(path))
                {
                    await s.WriteAsync(nameUser.StaffPortfolioFilesData[i].File);
                }







                //   file.nazv_p = nameUser.StaffPortfolioFilesData[i].;
                file.kategor_f = nameUser.StaffPortfolioFilesData[i].FileCategory.ToString();

                db.Entry(file).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                db.SaveChanges();


            }




            /*   for (int i = 0; i < nameUser.AcademicAwardsData.Length; i++)
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




            //}
            /*   db.Entry(nauch).State = Microsoft.EntityFrameworkCore.EntityState.Added;
               db.SaveChanges();
               /*var a = client.GetStaffInfoBySnils(Snils: snils).OrganizationData.Email;
               var b = client.GetStaffInfoBySnils(Snils: snils).MainPosition.AttestDate;*/

            ViewBag.User = db.Zayavlen.Where(p => p.Id == id).ToList();
            ViewBag.Obr = db.Obrazovan.Where(p => p.id_zayavl == id).ToList();
            ViewBag.File = db.File.Where(p => p.id_zayavl == id).ToList();
            ViewBag.Nauch = db.Naucn_deyat.Where(p => p.id_zayavl == id).ToList();
            return View("ZayavEdit", db.Zayavlen.Find(id));
        }




        public IActionResult view(int id_user, Users users)
        {

            return View("View", db.Zayavlen.Find(id_user));
        }


        [HttpGet]
        [Route("red")]
        public IActionResult red(int id)
        {
            return RedirectToAction("ZayavEdit", new { id });

        }


        [Route("edit/{id}")]
        public IActionResult Edit(int id, DataContext db)
        {
            var compositeModel = new CompositeModel(db);
            compositeModel.Zayavlen = new Zayavlen();
            compositeModel.FileModel = new FileModel();
            compositeModel.Obrazovan = new Obrazovan();
            compositeModel.Nauch_Deyat = new Nauch_deyat();
            compositeModel.Users = new Users();
            compositeModel.ProfRazv = new ProfRazv();

            compositeModel.listFile = db.File.Where(p => p.id_zayavl == id).ToList();
            compositeModel.listObrazovan = db.Obrazovan.Where(p => p.id_zayavl == id).ToList();
            compositeModel.listNauch_deyat = db.Naucn_deyat.Where(p => p.id_zayavl == id).ToList();
            compositeModel.listProfRazv = db.ProfRazv.Where(p => p.id_zayav == id).ToList();
            compositeModel.Zayavlen = db.Zayavlen.Find(id);
            ViewBag.compositeModel = compositeModel;
            return View("ZayavEdit", compositeModel);
        }

        public IActionResult file(int id, string name_f)
        {
            string path = Directory.GetCurrentDirectory() + "/wwwroot/Files/" + id + "/" + name_f;
            FileStream fs = new FileStream(path, FileMode.Open);
            string file_type = " multipart/form-data";
            string file_name = name_f;
            return File(fs, file_type, file_name);

        }


        public IActionResult Add()
        {

            return View();
        }



        public async Task<IActionResult> AddFile(IFormFile uploadedFile, CompositeModel compositeModel)
        {
            /*FileModel file = await db.File.Where(p => p.kategor_f == compositeModel.FileModel.kategor_f);
              db.File.Remove(file);
              db.SaveChanges();
              int id = compositeModel.Zayavlen.Id;
              if (uploadedFile != null)
              {
                  Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/wwwroot/Files/" +id);
                  // путь к папке Files
                  string path = Directory.GetCurrentDirectory() + "/wwwroot/Files/" + id + "/" + uploadedFile.FileName;
                  // сохраняем файл в папку Files в каталоге wwwroot
                  using (var fileStream = new FileStream(path, FileMode.Create))
                  {
                      await uploadedFile.CopyToAsync(fileStream);
                  }


                //  FileModel file = new FileModel();
                  file=new FileModel();
                  file.id_zayavl = id;
                  file.name_f = uploadedFile.FileName;
                  file.kategor_f = compositeModel.FileModel.kategor_f;
                  db.Entry(file).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                  db.SaveChanges();



              }
              */
            return View();
        }
        public IActionResult Creat()
        {


            var Email = HttpContext.User.Identity.Name;
            Users user = db.Users.Where(p => p.Email == Email).First();
            Zayavlen zayav = new Zayavlen();
            zayav.id_user = user.Id;

            zayav.data_obnovl = DateTime.Now;
            zayav.data_podachi = DateTime.Now;
            zayav.status = "Заявление на рассмотрении";

            db.Entry(zayav).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();







            return RedirectToAction("zayavEditFirst", "User", new { id = zayav.Id, id_user = user.Id });
        }


        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Users users)
        {
            db.Entry(users).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("User");
        }



        [Route("zayavEditFirst/{id}/{id_user}")]
        public async Task<IActionResult> ZayavEditFirst(int id, int id_user, Users user)
        {


            await Update(id_user, id, user);


            return RedirectToAction("Edit", "User", new { id });






        }


        [Route("zayav/{id}")]

        public IActionResult Zayav(int id)
        {
            ViewBag.User = db.Zayavlen.Where(p => p.Id == id).ToList();
            return View("ZayavEdit", db.Zayavlen.Find(id));

        }

        public IActionResult ZayavSaveEdit(int id_user, CompositeModel compositeModel)
        {

            db.Entry(compositeModel.Zayavlen).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            foreach (var row in compositeModel.listFile)
            {
                db.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            foreach (var row in compositeModel.listObrazovan)
            {
                db.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            foreach (var row in compositeModel.listNauch_deyat)
            {
                db.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            foreach (var row in compositeModel.listProfRazv)
            {
                db.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            /*db.Entry(compositeModel.Nauch_Deyat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           db.Entry(compositeModel.Obrazovan).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           db.Entry(compositeModel.ProfRazvModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;*/

            db.SaveChanges();
            return RedirectToAction("Lk", "Lk");
        }

        public IActionResult Save_Obr(int id_user, Zayavlen zayav)
        {

            db.Entry(zayav).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Lk", "Lk");
        }
    }
}