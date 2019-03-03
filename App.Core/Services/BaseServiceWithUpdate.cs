using App.Core.Interfaces.Models;
using App.Core.Interfaces.Repositories;
using App.Core.Interfaces.Services;
using App.Core.Sessions;

namespace App.Core.Services
{
    public abstract class BaseServiceWithUpdate<T> : BaseService<T>, IBaseServiceWithUpdate<T> where T : IBaseModelWithUpdate
    {
        protected new readonly IBaseRepositoryWithUpdate<T> repo;

        public BaseServiceWithUpdate(IBaseRepositoryWithUpdate<T> repo, SessionProvider sessionProvider) : base(repo, sessionProvider)
        {
            this.repo = repo;
        }
        
        public virtual Result<T> Update(T entity)
        {
            SetUpdateProperties(entity);
            repo.Update(entity);
            return new Result<T>(entity, true);
        }

        public virtual Result<T> Disable(T entity)
        {
            SetUpdateProperties(entity);
            repo.Disable(entity);
            return new Result<T>(entity, true);
        }

        protected override void SetInsertProperties(T entity)
        {
            var currDate = System.DateTime.Now;
            entity.AddDate = currDate;
            entity.AddBy = session.UserName;
            entity.ModDate = currDate;
            entity.ModBy = session.UserName;
        }

        protected virtual void SetUpdateProperties(T entity)
        {
            entity.ModDate = System.DateTime.Now;
            entity.ModBy = session.UserName;
        }
    }
}
