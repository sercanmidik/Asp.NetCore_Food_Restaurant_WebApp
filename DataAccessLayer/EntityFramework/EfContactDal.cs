using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        private readonly FoodContext _foodContext;
        public EfContactDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public Contact GetOneContact()
        {
            var value= _foodContext.Contacts.Where(x=>x.Status==true).First();
            return value ?? new Contact();
        }
    }

}
