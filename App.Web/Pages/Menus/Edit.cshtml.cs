using App.Core.Interfaces;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Web.Helper;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Pages.Menus
{
    public class EditModel : BasePageModelWithUpdate<Menu, MenuVM>
    { 
        public EditModel(IMenuService svc, IModelMapper<Menu, MenuVM> mapper) : base(svc, mapper) { }

        [BindProperty]
        public MenuVM Menu { get; set; }
        public Core.Result<Menu> Result { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = mapper.Map(svc.GetById(id.GetValueOrDefault()).Data);

            if (Menu == null)
            {
                return NotFound();
            } 
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                svc.Update(base.ModifyCoreModel(Menu));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(Menu.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MenuExists(int id)
        {
            return svc.GetById(id).ProcessingStatus;
        }
    }
}
