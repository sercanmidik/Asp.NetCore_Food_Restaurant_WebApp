using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfWorkTimeDal : GenericRepository<WorkTime>, IWorkTimeDal
    {
        private readonly FoodContext _foodContext;
        public EfWorkTimeDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public WorkTime GetOneWorkTime()
        {
            var value=_foodContext.WorkTimes.Where(x=>x.Status==true).FirstOrDefault();
            return value ?? new WorkTime();
        }
    }

}
