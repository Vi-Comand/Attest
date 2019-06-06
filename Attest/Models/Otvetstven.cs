using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attest.Models
{

    public class ListOtv : PageModel
    {
        public List<Otvetstven> ListOtvetstven { get; set; }
        public string dolg { get; set; }
        public string data_nachalo { get; set; }
        public string data_konec { get; set; }
        public string FIO { get; set; }
        public string specFIO { get; set; }
        public string napr_po_dolg { get; set; }
        public int kol { get; set; }
        public SortState sortOrder { get; set; }
    }

    public class Otvetstven
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime data_podachi { get; set; }
        public string oo { get; set; }
        public string dolgnost { get; set; }
        public string kategor { get; set; }
        public string file { get; set; }
        public string status { get; set; }
        public string ball { get; set; }
        public string narp_po_dolg { get; internal set; }
        public string spec { get; internal set; }
        public string mo { get; internal set; }
       
    }
}
