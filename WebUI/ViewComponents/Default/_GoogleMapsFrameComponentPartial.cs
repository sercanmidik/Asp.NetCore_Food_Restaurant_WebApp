using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _GoogleMapsFrameComponentPartial:ViewComponent
    {
        private readonly IContactService _contactService;

        public _GoogleMapsFrameComponentPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactService.BusinessGetOneContact();
            ViewBag.framestring = value.FrameString;
            return View();
        }
    }
}
