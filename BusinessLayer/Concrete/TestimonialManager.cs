using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.TestimonialDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void BusinessDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonial> BusinessGetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial BusinessGetById(int id)
        {
           return _testimonialDal.GetById(id);
        }

        public IEnumerable<ResultTestimonialDto> BusinessGetTestimonialForTrue()
        {
            var values = _testimonialDal.GetTestimonialForTrue().Select(x => new ResultTestimonialDto
            {
                Content = x.Content,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Status = x.Status,
                TestimonialId = x.TestimonialId,
                Title = x.Title,
            }).ToList();
            return values;
        }

        public void BusinessInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void BusinessUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
