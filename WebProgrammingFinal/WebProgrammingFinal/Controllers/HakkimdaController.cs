using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProgrammingFinal.CONTEXT;

namespace WebProgrammingFinal.Controllers
{
    public class HakkimdaController : Controller
    {
        private readonly AnasayfaDbContext _context;
        public HakkimdaController(AnasayfaDbContext context)
        {
            _context = context;
        }
        public IActionResult HakSayfasi()
        {

            var data = _context.Hakkimda.ToList();
            return View(data);
        }
    }
}
