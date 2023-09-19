using BasicBackendProject.Business.Abstract;
using BasicBackendProject.Core.Utilities.Results;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
                _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
          return  new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }
    }
}
