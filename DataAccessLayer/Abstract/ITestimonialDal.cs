using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface ITestimonialDal : IGenericDal<Testimonial>
    {
        public IEnumerable<Testimonial> GetTestimonialForTrue();
    }
}
