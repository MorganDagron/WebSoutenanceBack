using AdminWebBack.Data;
using AdminWebBack.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace AdminWebBack.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public async Task<ActionResult> Register(Admin admin)
        {
            admin.Password = BCrypt.Net.BCrypt.HashPassword(admin.Password);
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
            return Json(new { message = "Admin registered successfully" });
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var existingAdmin = _context.Admins.FirstOrDefault(a => a.Username == admin.Username);
            if (existingAdmin == null || !BCrypt.Net.BCrypt.Verify(admin.Password, existingAdmin.Password))
            {
                return Json(new { message = "Invalid username or password" });
            }

            Session["AdminUsername"] = existingAdmin.Username;
            return Json(new { message = "Login successful" });
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session.Remove("AdminUsername");
            return Json(new { message = "Logout successful" });
        }

        [HttpGet]
        public ActionResult Check()
        {
            var username = Session["AdminUsername"]?.ToString();
            if (username == null)
            {
                return Json(new { message = "Not logged in" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { username }, JsonRequestBehavior.AllowGet);
        }
    }
}
