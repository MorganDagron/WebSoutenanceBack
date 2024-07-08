using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSoutenanceBack.DAL
{
    public class UserDto
    {
        public string Mail { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdressePostale { get; set; }
        public string Telephone { get; set; }
        public bool IsAdmin { get; set; }
    }
}