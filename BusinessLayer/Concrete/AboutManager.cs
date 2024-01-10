using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.AboutDto;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public ResultAboutDto BusinesGetOneAbout()
        {
            var value = _aboutDal.GetOneAbout();
            ResultAboutDto result = new ResultAboutDto()
            {
                AboutId = value.AboutId,
                ContentOne=value.ContentOne,
                ContentTwo=value.ContentTwo,
                Icon = value.Icon,
                ImageUrlFour=value.ImageUrlFour,
                ImageUrlOne=value.ImageUrlOne,
                ImageUrlThree = value.ImageUrlThree,
                ImageUrlTwo=value.ImageUrlTwo,
                PersonCount=value.PersonCount,
                ServiceTime = value.ServiceTime,
                Status = value.Status,
                TitleOne=value.TitleOne,
                TitleTwo=value.TitleTwo,
            };
            return result;
        }

        public void BusinessDelete(About entity)
        {
           _aboutDal.Delete(entity);
        }

        public List<About> BusinessGetAll()
        {
            return _aboutDal.GetAll();
        }

        public About BusinessGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void BusinessInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void BusinessUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
