using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly FoodContext _foodContext;
        public EfCategoryDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public IEnumerable<Category> GetCategoriesTrue()
        {
            return _foodContext.Categories.Where(x=>x.Status==true);
        }
    }

}
