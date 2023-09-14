using BasicBackendProject.Core.DataAccess;
using BasicBackendProject.Entities.Concrete;
using BasicBackendProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
