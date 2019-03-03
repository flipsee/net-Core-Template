using App.Core.Models;
using App.Web.ViewModel;
using AutoMapper;

namespace App.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Menu
            CreateMap<Menu, MenuVM>();
            CreateMap<MenuVM, Menu>();

            // Add as many of these lines as you need to map your objects
            CreateMap<AccountClaim, IndexAccountClaimVM>();            
            CreateMap<IndexAccountClaimVM, AccountClaim>();
        }
    }
}
