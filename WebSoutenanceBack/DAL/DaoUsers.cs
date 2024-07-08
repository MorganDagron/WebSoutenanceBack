using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSoutenanceBack.DAL
{
    public class DaoUsers
    {

        public List<UserDto> FindAll()
        {
            using (soutenanceAJCEntities context = new soutenanceAJCEntities())
            {
                return context.Users.Select(u => new UserDto
                {
                    Mail = u.mail,
                    Nom = u.nom,
                    Prenom = u.prenom,
                    AdressePostale = u.adresse_postale,
                    Telephone = u.telephone,
                    IsAdmin = u.isAdmin ?? false
                }).ToList();
            }
        }

        public UserDto FindByMail(string mail)
        {
            using (soutenanceAJCEntities context = new soutenanceAJCEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.mail == mail);
                if (user == null) return null;

                return new UserDto
                {
                    Mail = user.mail,
                    Nom = user.nom,
                    Prenom = user.prenom,
                    AdressePostale = user.adresse_postale,
                    Telephone = user.telephone,
                    IsAdmin = user.isAdmin ?? false
                };
            }
        }

        /*public List<Users> FindAll()
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Users.ToList<Users>();
        }

        public Users FindByMail(string mail)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Users.FirstOrDefault(u => u.mail == mail);
        }*/

        public void Create(Users u)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Users.Add(u);
            context.SaveChanges();
        }

        public void Delete(string mail)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            Users user = context.Users.FirstOrDefault(u => u.mail == mail);
            if (user != null)
            {
                List<Authentification> auths = context.Authentification.Where(a => a.login == mail).ToList();
                foreach (var auth in auths)
                {
                    context.Authentification.Remove(auth);
                }
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public void Update(Users u)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Entry(u).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}