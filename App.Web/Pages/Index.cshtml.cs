using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Web.Helper;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Web.Pages
{
    
    public class IndexModel : BasePageModel
    {
        public IndexModel()
        {
            base.AddBreadcrumbs(new BreadcrumbVM("Home", "fa fa-dashboard"));
            base.AddBreadcrumbs(new BreadcrumbVM("Dashboard"));
        }

        public void OnGet()
        {

        }
    }
}
