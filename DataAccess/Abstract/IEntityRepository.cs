using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void UpDate(T entity);
        T Get(Expression<Func<T, bool>> filter);
    }
}
