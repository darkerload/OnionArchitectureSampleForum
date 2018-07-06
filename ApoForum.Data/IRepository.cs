﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApoForum.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
