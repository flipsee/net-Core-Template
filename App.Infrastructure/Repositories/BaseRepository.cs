using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using App.Core.Interfaces.Repositories;
using App.Core.Models;
using App.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace App.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel, IBaseModel
    {
        protected readonly ApplicationDbContext context;
        protected readonly DbSet<T> dbSet;
        
        public BaseRepository(ApplicationDbContext context) {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        protected IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(this.dbSet.AsQueryable(), spec);
        }

        public virtual T GetById(int Id)
        {
            return this.dbSet.Find(Id);
        }
        
        public virtual T GetBySpec(ISpecification<T> spec)
        {
            return Find(spec).FirstOrDefault();
        }

        public virtual ICollection<T> GetAll()
        {
            return this.dbSet.OrderByDescending(m => m.Id).ToList();
        }

        public virtual ICollection<T> Find(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }
        
        public virtual T Add(T entity)
        {
            this.dbSet.Add(entity);
            this.context.SaveChanges();
            return entity;
        }

        public virtual void Add(ICollection<T> entities)
        {
            this.dbSet.AddRange(entities);
            this.context.SaveChanges();            
        }
                 
        public virtual void Remove(int id)
        {
            T entity = dbSet.Find(id);
            Remove(entity);
        }

        public virtual void Remove(T entity)
        {
            this.dbSet.Remove(entity);
            this.context.SaveChanges();
        }

        public void Remove(ICollection<T> entities)
        {
            context.RemoveRange(entities);
            context.SaveChanges();
            //if (entities != null && entities.Count > 0)
            //{
            //    foreach (T item in entities)
            //    {
            //        Remove(item);
            //    }
            //}
        }


        /*
         * 
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
                                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

      
         */
    }
}
