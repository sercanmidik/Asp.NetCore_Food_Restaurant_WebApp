using DtoLayer.ContactDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        public ResultContactDto BusinessGetOneContact();
    }
 
}
