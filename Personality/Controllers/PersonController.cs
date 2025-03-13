using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personality.Models;

namespace Personality.Controllers
{
    public class PersonController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var datas = _context.Persons
                               .Include(p => p.MyServices)
                               .ToList();
            return View(datas);
        }
    }
}
