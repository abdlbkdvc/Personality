using Microsoft.AspNetCore.Mvc;
using Personality.Models;

namespace Personality.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var datas = context.Skills.ToList();
            return View(datas);
        }
    }
}
