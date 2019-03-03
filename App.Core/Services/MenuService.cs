using App.Core.Interfaces.Repositories;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Core.Sessions;

namespace App.Core.Services
{
    public class MenuService : BaseServiceWithUpdate<Menu>, IMenuService
    {        
        public MenuService(IMenuRepository repo, SessionProvider sessionProvider) : base(repo, sessionProvider)
        {
        }
    }
}
