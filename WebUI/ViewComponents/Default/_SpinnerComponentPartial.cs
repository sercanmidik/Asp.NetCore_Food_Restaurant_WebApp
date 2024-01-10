using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _SpinnerComponentPartial:ViewComponent
    {
        private readonly IEntryService _entryService;

        public _SpinnerComponentPartial(IEntryService entryService)
        {
            _entryService = entryService;
        }

        public IViewComponentResult Invoke()
        {
            var value=_entryService.BusinessGetOneTrueEntry();
            return View(value);
        }
    }
}
