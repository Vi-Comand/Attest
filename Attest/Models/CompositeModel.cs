using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attest.Models
{
    public class CompositeModel
    {
        public FileModel FileModel { get; set; }
        public Obrazovan Obrazovan { get; set; }
        public Zayavlen Zayavlen { get; set; }
        public Nauch_deyat Nauch_Deyat { get; set; }
        public Users Users { get; set; }
        public ProfRazvModel ProfRazvModel { get; set; }
    }


}
