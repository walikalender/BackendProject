﻿using BasicBackendProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BasicBackendProject.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        T Get(Expression<Func<T,bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
