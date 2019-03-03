using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using App.Core.Interfaces.Repositories;
using App.Core.Interfaces.Services;
using App.Core.Sessions;
using System.Collections.Generic;

namespace App.Core.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : IBaseModel
    {
        protected readonly IBaseRepository<T> repo;
        protected readonly Session session;

        public BaseService(IBaseRepository<T> repo, SessionProvider sessionProvider)
        {
            this.repo = repo;
            this.session = sessionProvider.session;
        }

        public virtual Result<T> GetById(int id)
        {
            Result<T> _result = new Result<T>(repo.GetById(id), true);
            return _result;
        }
        
        public virtual Result<T> GetBySpec(ISpecification<T> spec)
        {
            Result<T> _result = new Result<T>(repo.GetBySpec(spec), true);
            return _result;
        }

        public virtual Result<ICollection<T>> GetAll()
        {
            Result<ICollection<T>> _result = new Result<ICollection<T>>(repo.GetAll(), true);
            return _result;
        }

        public virtual Result<ICollection<T>> Find(ISpecification<T> spec)
        {
            Result<ICollection<T>> _result = new Result<ICollection<T>>(repo.Find(spec), true);
            return _result;
        }

        public virtual Result<T> Add(T entity)
        {
            SetInsertProperties(entity);
            repo.Add(entity);
            return new Result<T>(entity, true);
        }
        
        public virtual Result<T> Remove(T entity)
        {
            repo.Remove(entity);
            return new Result<T>(entity, true);
        }

        protected virtual void SetInsertProperties(T entity)
        {
            entity.AddDate = System.DateTime.Now;
            entity.AddBy = session.UserName;
        }
    }
}
