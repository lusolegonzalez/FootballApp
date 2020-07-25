using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Football.Data.Abstract
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IQueryable<T> Query(bool noTracking = false);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
