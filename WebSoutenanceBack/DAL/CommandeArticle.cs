//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSoutenanceBack.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommandeArticle
    {
        public int commande_id { get; set; }
        public int article_id { get; set; }
        public Nullable<int> quantite { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual Commande Commande { get; set; }
    }
}