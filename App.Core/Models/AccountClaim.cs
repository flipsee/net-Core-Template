using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("AccountClaim")]
    public class AccountClaim : BaseModelWithSequence
    {
        public AccountClaim()
        {
            Children = new HashSet<AccountClaim>();
        }

        public int? ParentId { get; set; }
        [Required, StringLength(100)]
        public string Type { get; set; }        
        [StringLength(100)]
        public string Value { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [ForeignKey("ParentId")]
        [InverseProperty("Children")]
        public AccountClaim Parent { get; set; }

        [InverseProperty("Parent")]
        public ICollection<AccountClaim> Children { get; set; }
    }
}
