using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void BusinessDelete(Book entity)
        {
            _bookDal.Delete(entity);
        }

        public List<Book> BusinessGetAll()
        {
            return _bookDal.GetAll();
        }

        public Book BusinessGetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public void BusinessInsert(Book entity)
        {
            _bookDal.Insert(entity);
        }

        public void BusinessUpdate(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
