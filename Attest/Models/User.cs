using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Attest.Models
{
    [Table("user")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public string Fam { get; set; }
        public string Snils { get; set; }
    }
}
