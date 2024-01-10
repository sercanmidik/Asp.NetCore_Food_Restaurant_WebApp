using DtoLayer.ServiceDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IServiceService : IGenericService<Service>
    {
        public IEnumerable<ResultServiceDto> BusinessGetFourServiceTrue();
    }
 
}
