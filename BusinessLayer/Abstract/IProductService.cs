using DtoLayer.ProductDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public IEnumerable<ResultProductDto> BusinessGetProductWithCategoryNameTrue();
    }
 
}
