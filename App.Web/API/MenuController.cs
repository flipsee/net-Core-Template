using App.Core.Interfaces;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace App.Web.Helper
{
    //[Authorize]
    public class MenuController : BaseApiController<Menu, MenuVM>
    {
        public MenuController(IMenuService service, IModelMapper<Menu, MenuVM> mapper) : base(service, mapper) { }

        [HttpGet]
        public override IEnumerable<MenuVM> Get()
        {
            var result = mapper.MapToList(svc.GetAll().Data);
            return result.Where(m => m.ParentId == null);
        }
    }
}
