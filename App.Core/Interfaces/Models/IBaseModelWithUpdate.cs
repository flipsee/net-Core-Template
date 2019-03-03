using System;
namespace App.Core.Interfaces.Models
{
    public interface IBaseModelWithUpdate : IBaseModel
    {
        string ModBy { get; set; }
        DateTime ModDate { get; set; }
        bool Disabled { get; set; }
    }
}
