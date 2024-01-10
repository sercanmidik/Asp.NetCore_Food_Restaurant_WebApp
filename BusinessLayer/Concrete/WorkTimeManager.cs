using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.WorkTimeDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WorkTimeManager : IWorkTimeService
    {
        private readonly IWorkTimeDal _workTimeDal;

        public WorkTimeManager(IWorkTimeDal workTimeDal)
        {
            _workTimeDal = workTimeDal;
        }

        public void BusinessDelete(WorkTime entity)
        {
           _workTimeDal.Delete(entity);
        }

        public List<WorkTime> BusinessGetAll()
        {
           return _workTimeDal.GetAll();
        }

        public WorkTime BusinessGetById(int id)
        {
           return _workTimeDal.GetById(id);
        }

        public ResultWorkTimeDto BusinessGetOneTrue()
        {
           var value=_workTimeDal.GetOneWorkTime();
            ResultWorkTimeDto result = new ResultWorkTimeDto()
            {
                BeginDay = value.BeginDay,
                Status = value.Status,
                BeginTime = value.BeginTime,
                FinishDay = value.FinishDay,
                FinishTime = value.FinishTime,
                WorkTimeId = value.WorkTimeId,
            };
            return result;
        }

        public void BusinessInsert(WorkTime entity)
        {
            _workTimeDal.Insert(entity);
        }

        public void BusinessUpdate(WorkTime entity)
        {
            _workTimeDal.Update(entity);
        }
    }
}
