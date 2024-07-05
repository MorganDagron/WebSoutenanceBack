using AdminWebBack.Data;
using AdminWebBack.Filters;
using AdminWebBack.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AdminWebBack.Controllers
{
    [AdminAuthorize]
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public async Task<ActionResult> GetArticles()
        {
            var articles = await _context.Articles.ToListAsync();
            return Json(articles, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<ActionResult> GetArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return Json(article, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<ActionResult> CreateArticle(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return Json(new { message = "Article created successfully" });
        }

        [HttpPut]
        public async Task<ActionResult> UpdateArticle(int id, Article article)
        {
            if (id != article.Id)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            _context.Entry(article).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return HttpNotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);
        }
    }
}
