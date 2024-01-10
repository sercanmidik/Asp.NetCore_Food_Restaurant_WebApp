using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IBrandDal : IGenericDal<Brand>
    {
        public Brand GetOneBrandTrue();
    }
}
