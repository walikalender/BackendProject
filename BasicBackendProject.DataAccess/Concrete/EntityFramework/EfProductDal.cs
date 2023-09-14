using BasicBackendProject.Core.DataAccess;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.DataAccess.Concrete.Context;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
