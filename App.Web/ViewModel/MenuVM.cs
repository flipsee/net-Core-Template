using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Web.ViewModel
{
    public class MenuVM : BaseVM
    {         
        public int? ParentId { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(100)]
        public string ClaimType { get; set; }
        [StringLength(100)]
        public string ClaimValue { get; set; }
        [StringLength(20)]
        public string Target { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [StringLength(300)]
        public string Url { get; set; }
        public bool Disabled { get; set; }
        public int Sequence { get; set; } = 99999;
        public ICollection<MenuVM> Children { get; set; }
    }
}
