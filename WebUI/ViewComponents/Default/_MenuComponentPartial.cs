using BusinessLayer.Abstract;
using DtoLayer.CategoryDtos;
using DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents.Default
{
    public class _MenuComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public _MenuComponentPartial(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
           
            CategoryWithProductViewModel model = new CategoryWithProductViewModel();
            model.Products = _productService.BusinessGetProductWithCategoryNameTrue();      
            model.Categories = _categoryService.BusinessGetCategoriesTrue();
            return View(model);
        }
    }
}
