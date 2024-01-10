using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _BrandComponentPartial:ViewComponent
    {
        private readonly IBrandService _brandService;

        public _BrandComponentPartial(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _brandService.BusinessGetOneBrandTrue();
            return View(value);
        }
    }
}
