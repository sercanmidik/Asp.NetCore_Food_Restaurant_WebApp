using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutUsComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var value=_aboutService.BusinesGetOneAbout();
            return View(value);
        }
    }
}
