using AdminWebBack.Data;
using AdminWebBack.Filters;
using AdminWebBack.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AdminWebBack.Controllers
{
    [AdminAuthorize]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<ActionResult> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Json(new { message = "Utilisateur créé avec succès" });
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(int id, User user)
        {
            if (id != user.Id)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);
        }
    }
}
