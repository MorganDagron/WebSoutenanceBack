using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSoutenanceBack.DAL;

namespace WebSoutenanceBack.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/<controller>
        public List<Users> Get()
        {
            return new DaoUsers().FindAll();
        }

        // GET api/<controller>/5
        public Users Get(int id)
        {
            return new DaoUsers().FindById(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Users u)
        {
            new DaoUsers().Create(u);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] Users u)
        {
            new DaoUsers().Update(u);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            new DaoUsers().Delete(id);
        }
    }
}