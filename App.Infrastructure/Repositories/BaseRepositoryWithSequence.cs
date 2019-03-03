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
    public abstract class BaseRepositoryWithSequence<T> : BaseRepositoryWithUpdate<T>, IBaseRepositoryWithUpdate<T> where T: BaseModelWithSequence, IBaseModelWithSequence
    { 
        public BaseRepositoryWithSequence(ApplicationDbContext context) : base(context) { 
        }
         
        public override ICollection<T> GetAll()
        {
            return this.dbSet.Where(m => m.Disabled == false).OrderBy(m => m.Sequence).OrderByDescending(m => m.Id).ToList();
        }         
    }
}
