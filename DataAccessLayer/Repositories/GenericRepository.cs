using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly FoodContext _foodContext;

        public GenericRepository(FoodContext foodContext)
        {
            _foodContext = foodContext;
        }

        public void Delete(T entity)
        {
            _foodContext.Remove(entity);
            _foodContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _foodContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _foodContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _foodContext.Add(entity);
            _foodContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _foodContext.Update(entity);
            _foodContext.SaveChanges();
        }
    }
}
