using BasicBackendProject.Business.Abstract;
using BasicBackendProject.Business.Constants;
using BasicBackendProject.Business.ValidationRules.FluentValidation;
using BasicBackendProject.Core;
using BasicBackendProject.Core.CrossCuttingConcerns;
using BasicBackendProject.Core.Utilities;
using BasicBackendProject.Core.Utilities.Results;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.Entities.Concrete;
using BasicBackendProject.Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValidationException = FluentValidation.ValidationException;

namespace BasicBackendProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            //business codes

            ValidationTool.Validate(new ProductValidator(), product);

            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);


        }
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==17)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }
        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
        }
        public IDataResult<List<Product>> GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll().Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList());
        }
        public IDataResult<List<Product>> DecreasedPrice()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll().OrderByDescending(p => p.UnitPrice).ToList());
        }
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public class OrnekModel
        {

        }
    }
}
