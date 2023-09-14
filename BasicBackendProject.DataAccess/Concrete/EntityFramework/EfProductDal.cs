using BasicBackendProject.Core.DataAccess.EntityFramework;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.DataAccess.Concrete.Context;
using BasicBackendProject.Entities.Concrete;
using BasicBackendProject.Entities.DTOs;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName,
                                 UnitsInStock = p.UnitsInStock
                             };

                return result.ToList();                
            }

            

                         
        }
    }
}
