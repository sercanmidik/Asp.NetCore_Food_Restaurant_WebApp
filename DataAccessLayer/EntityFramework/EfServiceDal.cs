using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        private readonly FoodContext _foodContext;
        public EfServiceDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public IEnumerable<Service> GetFourServiceTrue()
        {
            return _foodContext.Services.Where(x => x.Status == true).Take(4).ToList();
        }
    }

}
