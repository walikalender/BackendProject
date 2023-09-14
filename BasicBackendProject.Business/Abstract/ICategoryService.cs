using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();  
    }
}
