using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSoutenanceBack.DAL;
// comment 
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
        public Authentification Get(string login)
        {
            return new DaoAuthentification().FindByLogin(login);
        }


        [HttpPost]
        [Route("api/authentification/create")]
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

        // POST api/<controller>/login
        [HttpPost]
        [Route("api/authentification/login")]
        public Authentification Login([FromBody] Authentification authentification)
        {
            return new DaoAuthentification().FindByUsernameAndPassword(authentification.login, authentification.mot_de_passe);
        }
    }
}
