﻿using BasicBackendProject.Core.DataAccess;
using BasicBackendProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
