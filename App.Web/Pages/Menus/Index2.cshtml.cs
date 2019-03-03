using App.Core.Interfaces;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Web.Helper;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace App.Web.Pages.Menus
{
    public class IndexModel2 : BasePageModelWithUpdate<Menu, MenuVM>
    {
        public IndexModel2(IMenuService svc, IModelMapper<Menu, MenuVM> mapper): base(svc, mapper) {
            //base.breadcrumb.Add(new BreadcrumbVM("Home", "fa fa-dashboard"));
            //base.breadcrumb.Add(new BreadcrumbVM("Dashboard"));
        }

        public IList<MenuVM> Menu { get;set; }

        public IActionResult OnGet()
        {
            Menu = mapper.Map(svc.GetAll().Data).ToList();
            return Page();
        }
    }
}
