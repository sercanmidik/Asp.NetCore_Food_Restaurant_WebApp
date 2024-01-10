using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly FoodContext _foodContext;
        public EfProductDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public IEnumerable<Product> GetProductWithCategoryNameTrue()
        {
            var values=_foodContext.Products.Include("Category").Where(x=>x.Status==true).ToList();
            return values;
        }
    }

}
