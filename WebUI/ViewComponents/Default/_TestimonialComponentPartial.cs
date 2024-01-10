using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var value=_testimonialService.BusinessGetTestimonialForTrue();
            return View(value);
        }
    }
}
