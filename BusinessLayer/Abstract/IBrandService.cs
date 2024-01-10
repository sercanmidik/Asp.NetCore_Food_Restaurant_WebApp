using DtoLayer.BrandDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IBrandService : IGenericService<Brand>
    {
        public ResultBrandDto BusinessGetOneBrandTrue();
    }
 
}
