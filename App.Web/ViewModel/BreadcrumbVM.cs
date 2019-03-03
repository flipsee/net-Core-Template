using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModel
{
    public class BreadcrumbVM
    {
        public BreadcrumbVM(string description, string icon = "", string url = "#")
        {
            this.Description = description;
            this.Icon = icon;
            this.Url = url;
        }
                
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }        
    }
}
