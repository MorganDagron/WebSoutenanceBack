using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSoutenanceBack.DAL
{
    public class DaoUsers
    {
        public List<Users> FindAll()
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Users.ToList<Users>();
        }

        public Users FindById(int id)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            return context.Users.Find(id);
        }

        public void Create(Users u)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Users.Add(u);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            Users u = context.Users.Find(id);
            context.Users.Remove(u);
            context.SaveChanges();
        }

        public void Update(Users u)
        {
            soutenanceAJCEntities context = new soutenanceAJCEntities();
            context.Entry(u).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}