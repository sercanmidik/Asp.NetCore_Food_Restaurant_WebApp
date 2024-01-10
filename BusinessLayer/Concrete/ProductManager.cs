using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.ProductDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void BusinessDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> BusinessGetAll()
        {
            return _productDal.GetAll();
        }

        public Product BusinessGetById(int id)
        {
           return _productDal.GetById(id);
        }

        public IEnumerable<ResultProductDto> BusinessGetProductWithCategoryNameTrue()
        {
            List<ResultProductDto> resultProductDtos = new List<ResultProductDto>();
            var values = _productDal.GetProductWithCategoryNameTrue();
            foreach (var item in values)
            {
                resultProductDtos.Add(new ResultProductDto
                {
                    CategoryId = item.CategoryId,
                    CategoryName = item.Category.Name,
                    Name = item.Name,
                    Content = item.Content,
                    ImageUrl = item.ImageUrl,
                    Price = item.Price,
                    ProductId = item.ProductId,
                    Status = item.Status,

                });
            }
            return resultProductDtos;
        }

        public void BusinessInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void BusinessUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
