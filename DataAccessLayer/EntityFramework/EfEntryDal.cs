using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfEntryDal : GenericRepository<Entry>, IEntryDal
    {
        private readonly FoodContext _foodContext;
        public EfEntryDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public Entry GetOneTrueEntry()
        {
            var value= _foodContext.Entries.Where(x => x.Status == true).FirstOrDefault();
            if (value == null)
                return new Entry();
            return value;
        }
    }

}
