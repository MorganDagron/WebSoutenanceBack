using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebSoutenanceBack.DAL
{
    public class DaoAuthentification
    {
        public List<Authentification> FindAll()
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Authentification.ToList<Authentification>();
        }

        public Authentification FindByLogin(string login)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Authentification.Find(login);
        }

        public void Create(Authentification a)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Authentification.Add(a);
            context.SaveChanges();
        }

        public void Update(Authentification a)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Entry(a).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Authentification FindByUsernameAndPassword(string login, string mot_de_passe)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Authentification
                .Where(a => a.login == login && a.mot_de_passe == mot_de_passe)
                .FirstOrDefault();
        }
    }
}