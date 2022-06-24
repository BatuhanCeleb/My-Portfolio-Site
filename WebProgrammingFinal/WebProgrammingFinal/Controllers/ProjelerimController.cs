using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProgrammingFinal.CONTEXT;

namespace WebProgrammingFinal.Controllers
{
    public class ProjelerimController : Controller
    {
        private readonly AnasayfaDbContext _context;
        public ProjelerimController(AnasayfaDbContext context)
        {
            _context = context;
        }
        public IActionResult Proje()
        {
            var data = _context.Projelerim.ToList();
            return View(data);
        }
       
    }
}
