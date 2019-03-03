using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("LogEmail")]
    public partial class LogEmail : BaseModel
    {
        public int? EmailTemplateId { get; set; }
        [Required, StringLength(500)]
        public string Recepient { get; set; }
        [Required, StringLength(500)]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; }    
    }
}
