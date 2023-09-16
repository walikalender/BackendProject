using BasicBackendProject.Core.Utilities.Results;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>>GetAll();  
    }
}
