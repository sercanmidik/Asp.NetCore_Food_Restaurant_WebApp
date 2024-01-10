using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        public IEnumerable<Category> GetCategoriesTrue();
    }
}
