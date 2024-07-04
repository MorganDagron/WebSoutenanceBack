using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSoutenanceBack.DAL
{
    public class DaoArticle
    {
        public List<Article> FindAll()
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Article.ToList<Article>();
        }

        public Article FindById(int id)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Article.Find(id);
        }

        public void Create(Article a)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Article.Add(a);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            Article a = context.Article.Find(id);
            context.Article.Remove(a);
            context.SaveChanges();
        }

        public void Update(Article a)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Entry(a).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}