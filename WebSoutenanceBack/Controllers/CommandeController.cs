using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSoutenanceBack.DAL;

namespace WebSoutenanceBack.Controllers
{
    public class CommandeController : ApiController
    {
        // GET api/<controller>
        public List<Commande> Get()
        {
            return new DaoCommande().FindAll();
        }

        // GET api/<controller>/5
        public Commande Get(int id)
        {
            return new DaoCommande().FindById(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Commande c)
        {
            new DaoCommande().Create(c);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] Commande c)
        {
            new DaoCommande().Update(c);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            new DaoCommande().Delete(id);
        }
    }
}