using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("Configuration")]
    public partial class Configuration : BaseModelWithUpdate
    {
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string ValueType { get; set; }

        [StringLength(200)]
        public string Value { get; set; }
    }
}
