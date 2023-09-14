using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> DecreasedPrice();
        List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice);
    }
}
