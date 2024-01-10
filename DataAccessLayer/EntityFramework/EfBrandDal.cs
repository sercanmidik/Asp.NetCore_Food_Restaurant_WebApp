using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfBrandDal : GenericRepository<Brand>, IBrandDal
    {
        private readonly FoodContext _foodContext;
        public EfBrandDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public Brand GetOneBrandTrue()
        {
            var entity=_foodContext.Brands.Where(x=>x.Status==true).FirstOrDefault();
            return entity ?? new Brand();
        }
    }

}
