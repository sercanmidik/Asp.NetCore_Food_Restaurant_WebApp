using DtoLayer.EntryDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface IEntryService : IGenericService<Entry>
    {
        public ResultEntryDto BusinessGetOneTrueEntry();
    }
 
}
