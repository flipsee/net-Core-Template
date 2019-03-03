using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("Temp")]
    public class Temp : BaseModelWithUpdate
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
