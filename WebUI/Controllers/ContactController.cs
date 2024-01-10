using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        public PartialViewResult ContactUsImage()
        {
            return PartialView();
        }
    }
}
