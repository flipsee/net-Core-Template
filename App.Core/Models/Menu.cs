using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("Menu")]
    public partial class Menu : BaseModelWithSequence
    {
        public Menu()
        {
            Children = new HashSet<Menu>();
        }
 
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

        [ForeignKey("ParentId")]
        [InverseProperty("Children")]
        public Menu Parent { get; set; } 

        [InverseProperty("Parent")]
        public ICollection<Menu> Children { get; set; }
    }
}
