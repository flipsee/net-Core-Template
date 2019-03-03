using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("Document")]
    public partial class Document : BaseModelWithSequence
    {
        [Required, StringLength(50)]
        public string Type { get; set; }
        [Required, StringLength(200)]
        public string FileName { get; set; }
        [Required]
        public byte[] FileContent { get; set; }
        [StringLength(3000)]
        public string Remark { get; set; } 
    }
}
