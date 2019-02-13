using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  Attest.Models;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Auto(string Email,string pass)
        {
         
            

            Users user = await db.Users.FirstOrDefaultAsync(p => p.Email == Email);
            if (user != null && user.pass==pass)
                return Redirect(Url.Action("View/"+user.Id, "User"));

            return View("ненорм");
        }
    }
}