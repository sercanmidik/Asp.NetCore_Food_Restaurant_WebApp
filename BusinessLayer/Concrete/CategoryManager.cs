using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.CategoryDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void BusinessDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> BusinessGetAll()
        {
           return _categoryDal.GetAll();
        }

        public Category BusinessGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public IEnumerable<ResultCategoryDto> BusinessGetCategoriesTrue()
        {
            List<ResultCategoryDto> resultCategoryDtos = new List<ResultCategoryDto>();
            var values=_categoryDal.GetCategoriesTrue();
            foreach (var item in values)
            {
                resultCategoryDtos.Add(new ResultCategoryDto
                {
                    Status = item.Status,
                    CategoryId = item.CategoryId,
                    Icon= item.Icon,
                    Name= item.Name,
                });
            }
            return resultCategoryDtos;
        }

        public void BusinessInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void BusinessUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
