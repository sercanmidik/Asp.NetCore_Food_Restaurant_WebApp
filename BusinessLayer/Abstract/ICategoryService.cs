using DtoLayer.CategoryDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public IEnumerable<ResultCategoryDto> BusinessGetCategoriesTrue();
    }
 
}
