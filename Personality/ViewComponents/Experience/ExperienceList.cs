using Microsoft.AspNetCore.Mvc;
using Personality.Models;

namespace Personality.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var datas = context.Experiences.ToList();
            return View(datas);
        }
    }
}
