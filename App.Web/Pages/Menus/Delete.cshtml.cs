using App.Core.Interfaces;
using App.Core.Interfaces.Services;
using App.Core.Models;
using App.Web.Helper;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Pages.Menus
{
    public class DeleteModel : BasePageModelWithUpdate<Menu, MenuVM>
    {
        public DeleteModel(IMenuService svc, IModelMapper<Menu, MenuVM> mapper) : base(svc, mapper)
        { }

        [BindProperty]
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

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Menu = await _context.Menus.FindAsync(id);

            //if (Menu != null)
            //{
            //    _context.Menus.Remove(Menu);
            //    await _context.SaveChangesAsync();
            //}

            return RedirectToPage("./Index");
        }
    }
}
