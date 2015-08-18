﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blueprinter.Core.Data
{
    public interface IRepository<TEntity>
    {
        //Learn this code, is it good?
        IEnumerable<TEntity> All();
        bool Any(Expression<Func<TEntity, bool>> predicate);
        int Count { get; }
        TEntity Create(TEntity t);
        int Delete(TEntity t);
        int Delete(Expression<Func<TEntity, bool>> predicate);

        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        int Update(TEntity t);
    }
}
