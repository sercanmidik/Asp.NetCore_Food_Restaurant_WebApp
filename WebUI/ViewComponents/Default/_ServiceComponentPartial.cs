using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _ServiceComponentPartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServiceComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var value=_serviceService.BusinessGetFourServiceTrue();
            return View(value);
        }
    }
}
