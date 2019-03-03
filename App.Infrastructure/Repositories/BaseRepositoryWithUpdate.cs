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
    public abstract class BaseRepositoryWithUpdate<T> : BaseRepository<T>, IBaseRepositoryWithUpdate<T> where T: BaseModelWithUpdate, IBaseModelWithUpdate 
    { 
        public BaseRepositoryWithUpdate(ApplicationDbContext context) : base(context) { 
        }
        
        public override ICollection<T> GetAll()
        {
            return this.dbSet.Where(m => m.Disabled == false).OrderByDescending(m => m.Id).ToList();
        }


        public virtual void Update(T entityToUpdate)
        {
            context.Entry(entityToUpdate).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Update(ICollection<T> entities)
        {
            context.UpdateRange(entities);
            context.SaveChanges();

            //if (entities != null && entities.Count > 0)
            //{
            //    foreach (T item in entities)
            //    {
            //        Update(item);
            //    }
            //}
        }

        public virtual void Disable(int id)
        {
            T entity = dbSet.Find(id);
            Disable(entity);
        }
        
        public virtual void Disable(T entity)
        {
            entity.Disabled = true;
            Update(entity);
            //context.Entry(entity).State = EntityState.Modified;
            //context.SaveChanges();
        }

        public virtual void Disable(ICollection<T> entities)
        {
            if (entities != null && entities.Count > 0)
            {
                foreach (T item in entities)
                {
                    item.Disabled = true;
                }
                Update(entities);
            }            
        }         
    }
}
