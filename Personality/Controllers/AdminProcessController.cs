using Microsoft.AspNetCore.Mvc;
using Personality.Models;

namespace Personality.Controllers
{
    public class AdminProcessController : Controller
    {
        Context context = new();

        [HttpGet]
        public IActionResult AboutList()
        {
            var datas = context.Persons.ToList();
            return View(datas);
        }
        //public IActionResult AboutAdd()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AboutAdd(Person p)
        //{
        //    context.Add(p);
        //    context.SaveChanges();
        //    return RedirectToAction("AboutList");
        //}

        [HttpGet]
        public IActionResult AboutDelete(int id)
        {
            var data = context.Persons.Find(id);
            return View(data);
        }

    }
}
