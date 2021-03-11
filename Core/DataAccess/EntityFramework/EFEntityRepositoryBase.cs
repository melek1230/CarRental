using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using System.Linq.Expressions;
using System.Linq;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }



        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void UpDate(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        //public List<TEntity> GetAllByBrand(Expression<Func<TEntity, bool>> filter)
        //{
        //    using (TContext context = new TContext())
        //    {
        //        return context.Set<TEntity>().Where(filter).ToList();
        //    }
        //}

        //public List<TEntity> GetAllByColor(Expression<Func<TEntity, bool>> filter)
        //{
        //    using (TContext context = new TContext())
        //    {
        //        return context.Set<TEntity>().Where(filter).ToList();
        //    }
        //}
    }
}
