using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public IEnumerable<Product> GetProductWithCategoryNameTrue();
    }
}
