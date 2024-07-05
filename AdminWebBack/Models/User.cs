using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminWebBack.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string AdressePostale { get; set; }
        public string Telephone { get; set; }
    }
}
