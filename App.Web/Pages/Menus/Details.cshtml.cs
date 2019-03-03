using App.Core.Interfaces;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Web.Helper;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Pages.Menus
{
    public class DetailsModel : BasePageModelWithUpdate<Menu, MenuVM>
    {
        public DetailsModel(IMenuService svc, IModelMapper<Menu, MenuVM> mapper) : base(svc, mapper) { }

        public Menu Menu { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = svc.GetById(id.GetValueOrDefault()).Data;
            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
