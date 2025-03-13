using Microsoft.AspNetCore.Mvc;

namespace Personality.Controllers
{
    public class AdminLayoutController : Controller
    {
       public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
