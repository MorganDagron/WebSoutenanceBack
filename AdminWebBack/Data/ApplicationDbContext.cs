using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AdminWebBack.Models;

namespace AdminWebBack.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandeArticle> CommandeArticles { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Taille> Tailles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommandeArticle>()
                .HasKey(ca => new { ca.CommandeId, ca.ArticleId });

            modelBuilder.Entity<CommandeArticle>()
                .HasRequired(ca => ca.Commande)
                .WithMany(c => c.CommandeArticles)
                .HasForeignKey(ca => ca.CommandeId);

            modelBuilder.Entity<CommandeArticle>()
                .HasRequired(ca => ca.Article)
                .WithMany()
                .HasForeignKey(ca => ca.ArticleId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
