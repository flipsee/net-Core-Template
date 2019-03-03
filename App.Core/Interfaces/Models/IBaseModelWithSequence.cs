using System;
namespace App.Core.Interfaces.Models
{
    public interface IBaseModelWithSequence : IBaseModelWithUpdate
    {
        int Sequence { get; set; }
    }
}
