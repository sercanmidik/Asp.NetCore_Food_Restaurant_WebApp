using DtoLayer.CategoryDtos;
using DtoLayer.ProductDtos;

namespace WebUI.Models
{
    public class CategoryWithProductViewModel
    {
        public IEnumerable<ResultCategoryDto> Categories { get; set; }
        public IEnumerable<ResultProductDto> Products { get; set; }

    }
}
