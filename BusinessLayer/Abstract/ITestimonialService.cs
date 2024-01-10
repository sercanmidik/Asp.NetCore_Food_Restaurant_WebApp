using DtoLayer.TeamFriendDtos;
using DtoLayer.TestimonialDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface ITestimonialService : IGenericService<Testimonial>
    {
        public IEnumerable<ResultTestimonialDto> BusinessGetTestimonialForTrue();
    }
 
}
