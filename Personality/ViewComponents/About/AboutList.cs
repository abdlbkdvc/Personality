using Microsoft.AspNetCore.Mvc;
using Personality.Models;

namespace Personality.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        Context context = new();
        public IViewComponentResult Invoke()
        {
            var datas = context.Persons.ToList();
            return View(datas);
        }
    }
}
