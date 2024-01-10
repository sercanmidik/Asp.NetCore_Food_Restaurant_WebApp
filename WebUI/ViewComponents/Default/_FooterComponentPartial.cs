using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Default
{
    public class _FooterComponentPartial:ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IWorkTimeService _workTimeService;

        public _FooterComponentPartial(IContactService contactService, IWorkTimeService workTimeService)
        {
            _contactService = contactService;
            _workTimeService = workTimeService;
        }

        public IViewComponentResult Invoke()
        {
            ContactAndWorkTimeViewModel viewModel = new ContactAndWorkTimeViewModel()
            {
                Contact = _contactService.BusinessGetOneContact(),
                WorkTime = _workTimeService.BusinessGetOneTrue(),
            };
            return View(viewModel);
        }
    }
}
