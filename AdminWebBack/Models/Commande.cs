using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminWebBack.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public User User { get; set; }
        public ICollection<CommandeArticle> CommandeArticles { get; set; }
    }
}
