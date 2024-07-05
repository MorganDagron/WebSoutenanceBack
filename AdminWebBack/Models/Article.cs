using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminWebBack.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Categorie { get; set; }
        public int TailleId { get; set; }
        public int MatiereId { get; set; }

        public Taille Taille { get; set; }
        public Matiere Matiere { get; set; }
    }
}