using System;
namespace App.Core.Interfaces.Models
{
    public interface IBaseModel
    {
        int Id { get; set; }
        string AddBy { get; set; }
        DateTime AddDate { get; set; }
    }
}
