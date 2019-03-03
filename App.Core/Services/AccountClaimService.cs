using App.Core.Interfaces.Repositories;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Core.Sessions;

namespace App.Core.Services
{
    public class AccountClaimService : BaseServiceWithUpdate<AccountClaim>, IAccountClaimService
    {        
        public AccountClaimService(IAccountClaimRepository repo, SessionProvider sessionProvider) : base(repo, sessionProvider)
        {
        }
    }
}
