using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.EntryDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EntryManager : IEntryService
    {
        private readonly IEntryDal _entryDal;

        public EntryManager(IEntryDal entryDal)
        {
            _entryDal = entryDal;
        }

        public void BusinessDelete(Entry entity)
        {
            _entryDal.Delete(entity);
        }

        public List<Entry> BusinessGetAll()
        {
            return _entryDal.GetAll();
        }

        public Entry BusinessGetById(int id)
        {
            return _entryDal.GetById(id);
        }

        public void BusinessInsert(Entry entity)
        {
            _entryDal.Insert(entity);
        }

        public void BusinessUpdate(Entry entity)
        {
           _entryDal.Update(entity);
        }

        public ResultEntryDto BusinessGetOneTrueEntry()
        {
           var value=_entryDal.GetAll().Where(x=>x.Status==true).First();
            ResultEntryDto result = new ResultEntryDto()
            {
                Content=value.Content,
                Status=value.Status,
                EntryId=value.EntryId,
                ImageUrl=value.ImageUrl,
                TitleOne = value.TitleOne,
                TitleTwo = value.TitleTwo
            };
            return result;
        }
    }
}
