using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _ContactComponentPartial:ViewComponent
    {
        private readonly IContactService _contactService;

        public _ContactComponentPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var value=_contactService.BusinessGetOneContact();
            return View(value);
        }
    }
}
