﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class soutenanceAJCEntities : DbContext
    {
        public soutenanceAJCEntities()
            : base("name=soutenanceAJCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Authentification> Authentification { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<CommandeArticle> CommandeArticle { get; set; }
        public virtual DbSet<Matiere> Matiere { get; set; }
        public virtual DbSet<Taille> Taille { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<BlogArticle> BlogArticle { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
    }
}
