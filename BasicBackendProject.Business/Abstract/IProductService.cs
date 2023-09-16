using BasicBackendProject.Core;
using BasicBackendProject.Core.Utilities.Results;
using BasicBackendProject.Entities.Concrete;
using BasicBackendProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> DecreasedPrice();
        IDataResult<List<Product>> GetProductsByPriceRange(int minPrice, int maxPrice);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
