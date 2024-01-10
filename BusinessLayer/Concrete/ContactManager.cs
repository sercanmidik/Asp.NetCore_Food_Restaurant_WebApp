using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.ContactDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void BusinessDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> BusinessGetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact BusinessGetById(int id)
        {
           return _contactDal.GetById(id);
        }

        public ResultContactDto BusinessGetOneContact()
        {
            var value= _contactDal.GetOneContact();
            ResultContactDto result = new ResultContactDto()
            {
                Address = value.Address,
                ContactId = value.ContactId,
                Email=value.Email,
                FacebookUrl=value.FacebookUrl,
                FoodBasketUrl = value.FoodBasketUrl,
                FrameString = value.FrameString,
                InstagramUrl = value.InstagramUrl,
                PhoneNumber = value.PhoneNumber,
                Status = value.Status,
                TwitterUrl = value.TwitterUrl

            };
            return result;
        }

        public void BusinessInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void BusinessUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
