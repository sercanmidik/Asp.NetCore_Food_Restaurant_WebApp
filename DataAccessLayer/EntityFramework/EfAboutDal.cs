using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        private readonly FoodContext _foodContext;
        public EfAboutDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public About GetOneAbout()
        {
            var value= _foodContext.Abouts.Where(x => x.Status == true).FirstOrDefault();
            return value ?? new About();
        }
    }

}
