using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface IEntryDal : IGenericDal<Entry>
    {
        public Entry GetOneTrueEntry();
    }
}
