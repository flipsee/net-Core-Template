using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("Lookup")]
    public partial class Lookup : BaseModelWithSequence
    {
        [Required, StringLength(100)]        
        public string Type { get; set; }
        [Required, StringLength(100)]
        public string Code { get; set; }
        [Required, StringLength(300)]
        public string Description { get; set; } 
    }
}
