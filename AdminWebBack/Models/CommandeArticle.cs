using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminWebBack.Models
{
    public class CommandeArticle
    {
        public int CommandeId { get; set; }
        public int ArticleId { get; set; }
        public int Quantite { get; set; }

        public Commande Commande { get; set; }
        public Article Article { get; set; }
    }
}
