using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Interfaces.Models;
namespace App.Core.Models
{
    public abstract class BaseModelWithSequence : BaseModelWithUpdate, IBaseModelWithSequence
    {
        [Column(Order = 107)]
        public int Sequence { get; set; } = 99999;
    }
}
