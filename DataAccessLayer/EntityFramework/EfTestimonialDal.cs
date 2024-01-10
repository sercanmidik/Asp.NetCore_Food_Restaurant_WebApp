using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        private readonly FoodContext _foodContext;
        public EfTestimonialDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public IEnumerable<Testimonial> GetTestimonialForTrue()
        {
            return _foodContext.Testimonials.Where(x=>x.Status==true).ToList();
        }
    }

}
