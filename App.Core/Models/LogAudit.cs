using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("LogAudit")]
    public partial class LogAudit : BaseModel
    {
        [Required, StringLength(300)]
        public string Action { get; set; }
        [Required, StringLength(300)]
        public string TableName { get; set; }
        public int? RecordId { get; set; }
        [Required, StringLength(300)]
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
