using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Interfaces.Models;

namespace App.Core.Models
{
    public abstract class BaseModel : IBaseModel
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        
        [Required, StringLength(256), Column(Order = 102)]
        public string AddBy { get; set; }
        [Column(Order = 103)]
        public DateTime AddDate { get; set; } 
    }
}
