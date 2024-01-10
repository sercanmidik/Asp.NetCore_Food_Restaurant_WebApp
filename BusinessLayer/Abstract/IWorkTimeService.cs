using DtoLayer.WorkTimeDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IWorkTimeService : IGenericService<WorkTime>
    {
        public ResultWorkTimeDto BusinessGetOneTrue();
    }
 
}
