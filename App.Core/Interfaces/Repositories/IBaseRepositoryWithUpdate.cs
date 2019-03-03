using App.Core.Interfaces.Models;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Interfaces.Repositories
{    
    public interface IBaseRepositoryWithUpdate<T> : IBaseRepository<T> where T : IBaseModelWithUpdate
    {
        void Update(T entity);
        void Update(ICollection<T> entities);

        void Disable(int id);
        void Disable(T entity);
        void Disable(ICollection<T> entities);
    }
}
