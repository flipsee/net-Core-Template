using App.Core.Interfaces.Models;
using System.Collections.Generic;

namespace App.Core.Interfaces.Services
{
    public interface IBaseServiceWithUpdate<T> : IBaseService<T> where T : IBaseModelWithUpdate
    {
        Result<T> Update(T entity);
        Result<T> Disable(T entity);
    }
}
