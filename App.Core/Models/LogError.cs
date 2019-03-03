using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("LogError")]
    public partial class LogError : BaseModel
    {
        [StringLength(100)]
        public string DbName { get; set; }
        [StringLength(100)]
        public string DbServerName { get; set; }
        [StringLength(300)]
        public string Url { get; set; }
        [StringLength(100)]
        public string Source { get; set; }
        public string Message { get; set; }
    }
}
