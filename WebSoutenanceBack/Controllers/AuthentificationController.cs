using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSoutenanceBack.DAL;

namespace WebSoutenanceBack.Controllers
{
    public class AuthentificationController : ApiController
    {
        // GET api/<controller>
        public List<Authentification> Get()
        {
            return new DaoAuthentification().FindAll();
        }

        // GET api/<controller>/5
        public Authentification Get(int id)
        {
            return new DaoAuthentification().FindById(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Authentification a)
        {
            new DaoAuthentification().Create(a);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] Authentification a)
        {
            new DaoAuthentification().Update(a);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            new DaoAuthentification().Delete(id);
        }

        // POST api/<controller>/login
        public Authentification Login([FromBody] Authentification authentification)
        {
            return new DaoAuthentification().FindByUsernameAndPassword(authentification.login, authentification.mot_de_passe);
        }
    }
}