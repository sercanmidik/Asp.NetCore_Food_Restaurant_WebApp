using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IWorkTimeDal : IGenericDal<WorkTime>
    {
        public WorkTime GetOneWorkTime();
    }
}
