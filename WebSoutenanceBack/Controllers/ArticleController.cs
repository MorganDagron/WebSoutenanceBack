using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSoutenanceBack.DAL;
using System.Web.Http.Cors; 

namespace WebSoutenanceBack.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ArticleController : ApiController
    {
        // GET api/<controller>
        public List<Article> Get()
        {
            return new DaoArticle().FindAll();
        }

        // GET api/<controller>/5
        public Article Get(int id)
        {
            return new DaoArticle().FindById(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Article a)
        {
            new DaoArticle().Create(a);
        }

        // PUT api/<controller>/5
        public void Put([FromBody] Article a)
        {
            new DaoArticle().Update(a);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            new DaoArticle().Delete(id);
        }
    }
}