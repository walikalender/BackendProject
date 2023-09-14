using BasicBackendProject.Business.Abstract;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBackendProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);   
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
           return _productDal.Get(p => p.ProductId == id);
        }

        public List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _productDal.GetAll().Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList();
        }

        public List<Product> DecreasedPrice()
        {
            return _productDal.GetAll().OrderByDescending(p => p.UnitPrice).ToList();
        }
    }
}
