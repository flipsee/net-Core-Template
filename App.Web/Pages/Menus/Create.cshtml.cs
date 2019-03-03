using App.Core.Interfaces;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Web.Helper;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Pages.Menus
{
    public class CreateModel : BasePageModelWithUpdate<Menu, MenuVM>
    { 
        public CreateModel(IMenuService svc, IModelMapper<Menu, MenuVM> mapper) : base(svc, mapper) { }

        public void OnGet()
        {
            
        }

        [BindProperty]
        public MenuVM Menu { get; set; }
        public Core.Result<Menu> Result { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Result = svc.Add(mapper.Map(Menu));
            if (Result.ProcessingStatus)
            {
                return Page();
            }
            return Page();
        }
    }
}