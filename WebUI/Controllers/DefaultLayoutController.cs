using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class DefaultLayoutController : Controller
    {
        public IActionResult _DefaultLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult SpinPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
