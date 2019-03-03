using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Interfaces.Models;
namespace App.Core.Models
{
    public abstract class BaseModelWithUpdate : BaseModel, IBaseModelWithUpdate
    {
        [Required, StringLength(256), Column(Order = 104)]
        public string ModBy { get; set; }
        [Column(Order = 105)]
        public DateTime ModDate { get; set; }
        [Column(Order = 106)]
        public bool Disabled { get; set; } = false;
    }
}
