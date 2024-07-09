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
        private DaoUsers daoUsers = new DaoUsers();

        // GET api/Users
        public List<UserDto> Get()
        {
            return new DaoUsers().FindAll();
        }

        // GET api/Users?mail=admin@example.com
        public UserDto Get(string mail)
        {
            return new DaoUsers().FindByMail(mail);
        }

        // DELETE api/Users?mail=admin@example.com
        public void Delete(string mail)
        {
            new DaoUsers().Delete(mail);
        }
        // GET api/<controller>
       /* public List<Users> Get()
        {
            return new DaoUsers().FindAll();
        }

        // GET api/<controller>/5
        public Users Get(string mail)
        {
            return new DaoUsers().FindByMail(mail);
        }*/
        // POST api/<controller>
        public void Post([FromBody] Users u)
        {
            new DaoUsers().Create(u);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] UserDto u)
        {
            new DaoUsers().Update(u);
        }

        // DELETE api/<controller>/5
        /*public void Delete(string mail)
        {
            new DaoUsers().Delete(mail);
        }*/
    }
}