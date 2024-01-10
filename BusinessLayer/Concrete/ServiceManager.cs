using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.ServiceDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void BusinessDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> BusinessGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service BusinessGetById(int id)
        {
           return _serviceDal.GetById(id);
        }

        public IEnumerable<ResultServiceDto> BusinessGetFourServiceTrue()
        {
            List<ResultServiceDto> resultServiceDtos = new List<ResultServiceDto>();
            var values = _serviceDal.GetFourServiceTrue();
            foreach (var value in values)
            {
                resultServiceDtos.Add(new ResultServiceDto
                {
                    Content= value.Content,
                    ImageUrl= value.ImageUrl,
                    ServiceId=value.ServiceId,
                    Status=value.Status,
                    Title=value.Title,
                });
            }
            return resultServiceDtos;
        }

        public void BusinessInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void BusinessUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
