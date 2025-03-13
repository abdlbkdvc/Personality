using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personality.Models;

namespace Personality.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        Context context = new();
        public IViewComponentResult Invoke()
        {
            var datas = context.Persons
                .Include(p => p.MyServices)
                .ToList();
            return View(datas);
        }
    }
}
