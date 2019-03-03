using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace App.Web.ViewModel
{
    public abstract class BaseVM
    {
        [Key]
        public int Id { get; set; } 


    }
}
