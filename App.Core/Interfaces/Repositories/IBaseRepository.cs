using App.Core.Interfaces.Models;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Interfaces.Repositories
{    
    public interface IBaseRepository<T> where T : IBaseModel
    {
        T GetById(int id);
        T GetBySpec(ISpecification<T> spec);
        ICollection<T> GetAll();

        ICollection<T> Find(ISpecification<T> spec);
        int Count(ISpecification<T> spec);

        T Add(T entity);
        void Add(ICollection<T> entities);
         
        void Remove(int id);
        void Remove(T entity);
        void Remove(ICollection<T> entities);        
    }
}
