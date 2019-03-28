using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Attest.Models

{
    public class CompositeModel:PageModel
    {
        private readonly DataContext _context;
        public List<FileModel> listFile { get; set; }
        public FileModel FileModel { get; set; }
        public List<Obrazovan> listObrazovan { get; set; }
        public Obrazovan Obrazovan { get; set; }
        public Zayavlen Zayavlen { get; set; }
        public List<Nauch_deyat> listNauch_deyat { get; set; }
        public Nauch_deyat Nauch_Deyat { get; set; }
        public Users Users { get; set; }
        //public ProfRazvModel ProfRazvModel { get; set; }

        public CompositeModel()
        {
            
        }
        public CompositeModel(DataContext db)
        {
            _context = db;
        }

     

        //public CompositeModel(DataContext db)
        //{
        //    _context = db;
        //}
        //public void OnGet()
        //{
        //   var FileModels = _context.File.AsNoTracking().ToList();
        //}


    }

}
