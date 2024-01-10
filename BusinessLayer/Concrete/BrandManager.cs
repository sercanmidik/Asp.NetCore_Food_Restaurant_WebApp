using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.BrandDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void BusinessDelete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public List<Brand> BusinessGetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand BusinessGetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public ResultBrandDto BusinessGetOneBrandTrue()
        {
            var value=_brandDal.GetOneBrandTrue();
            ResultBrandDto result = new ResultBrandDto()
            {
                BrandId = value.BrandId,
                Icon = value.Icon,
                Name = value.Name,
                Status = value.Status,
            };
            return result;
        }

        public void BusinessInsert(Brand entity)
        {
            _brandDal.Insert(entity);
        }

        public void BusinessUpdate(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
