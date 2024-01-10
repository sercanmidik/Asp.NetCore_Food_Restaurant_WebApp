using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        public Contact GetOneContact();
    }
}
