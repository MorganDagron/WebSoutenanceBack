using AdminWebBack.Data;
using AdminWebBack.Filters;
using AdminWebBack.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AdminWebBack.Controllers
{
    [AdminAuthorize]
    public class CommandesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommandesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public async Task<ActionResult> GetCommandes()
        {
            var commandes = await _context.Commandes.ToListAsync();
            return Json(commandes, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<ActionResult> GetCommande(int id)
        {
            var commande = await _context.Commandes.FindAsync(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            return Json(commande, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCommande(Commande commande)
        {
            _context.Commandes.Add(commande);
            await _context.SaveChangesAsync();
            return Json(new { message = "Commande créée avec succes" });
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCommande(int id, Commande commande)
        {
            if (id != commande.Id)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            _context.Entry(commande).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCommande(int id)
        {
            var commande = await _context.Commandes.FindAsync(id);
            if (commande == null)
            {
                return HttpNotFound();
            }

            _context.Commandes.Remove(commande);
            await _context.SaveChangesAsync();
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);
        }
    }
}
