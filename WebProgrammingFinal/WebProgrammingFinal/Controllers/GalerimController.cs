using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProgrammingFinal.CONTEXT;

namespace WebProgrammingFinal.Controllers
{
    public class GalerimController : Controller
    {
        private readonly AnasayfaDbContext _context;
        public GalerimController(AnasayfaDbContext context)
        {
            _context = context;
        }
        public IActionResult Medya()
        {

            var data = _context.Galerim.ToList();
            return View(data);

        }
    }
}
