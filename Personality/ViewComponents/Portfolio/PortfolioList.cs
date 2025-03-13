using Microsoft.AspNetCore.Mvc;
using Personality.Models;

namespace Personality.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var datas = context.Projects.ToList();
            return View(datas);
        }
    }
}
