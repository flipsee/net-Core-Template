using App.Core;
using App.Core.Interfaces.Repositories;
using App.Core.Models;
using App.Infrastructure.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace App.Infrastructure.Repositories
{
    public class AccountClaimRepository : BaseRepositoryWithSequence<AccountClaim>, IAccountClaimRepository 
    {
        public AccountClaimRepository(ApplicationDbContext context) : base(context)
        {
        }        
    }
}
