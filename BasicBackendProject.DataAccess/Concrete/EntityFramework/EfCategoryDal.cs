using BasicBackendProject.Core.DataAccess.EntityFramework;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.DataAccess.Concrete.Context;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
