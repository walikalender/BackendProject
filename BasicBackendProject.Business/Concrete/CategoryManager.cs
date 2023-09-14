using BasicBackendProject.Business.Abstract;
using BasicBackendProject.DataAccess.Abstract;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Business.Concrete
{
    internal class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
                _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
          return  _categoryDal.GetAll();
        }
    }
}
