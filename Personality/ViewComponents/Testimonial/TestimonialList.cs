using Microsoft.AspNetCore.Mvc;
using Personality.Models;

namespace Personality.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var datas = context.Testimonials.ToList();
            return View(datas);
        }
    }
}
