using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSoutenanceBack.DAL
{
    public class DaoCommande
    {
        public List<Commande> FindAll()
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Commande.ToList<Commande>();
        }

        public Commande FindById(int id)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Commande.Find(id);
        }

        public void Create(Commande c)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Commande.Add(c);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            Commande c = context.Commande.Find(id);
            context.Commande.Remove(c);
            context.SaveChanges();
        }

        public void Update(Commande c)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Entry(c).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<Commande> FindByUser(string mail)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Commande.Where(c => c.mail == mail).ToList<Commande>();
        }

        public List<Article> FindArticlesByCommande(int commandeId)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.CommandeArticle
                .Where(ca => ca.commande_id == commandeId)
                .Select(ca => ca.Article)
                .ToList<Article>();
        }
    }
}