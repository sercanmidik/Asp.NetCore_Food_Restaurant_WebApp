using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IServiceDal : IGenericDal<Service>
    {
        public IEnumerable<Service> GetFourServiceTrue();
    }
}
