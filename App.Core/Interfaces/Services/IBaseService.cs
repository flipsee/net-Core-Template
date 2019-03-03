using App.Core.Interfaces.Models;
using System.Collections.Generic;

namespace App.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : IBaseModel
    {
        Result<T> GetById(int id);
        Result<T> GetBySpec(ISpecification<T> spec);
        Result<ICollection<T>> GetAll();
        Result<ICollection<T>> Find(ISpecification<T> spec);

        Result<T> Add(T entity);
        
        Result<T> Remove(T entity); 
    }
}
