using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProgrammingFinal.CONTEXT;

namespace WebProgrammingFinal.Controllers
{
    public class AnasayfaController : Controller
    {
        private readonly AnasayfaDbContext _context;
        public AnasayfaController(AnasayfaDbContext context)
        {
            _context = context;
        }
        public IActionResult Baslangic()
        {
           
            var data = _context.Anasayfa.ToList();
            return View(data);
             
        }
    }
}
