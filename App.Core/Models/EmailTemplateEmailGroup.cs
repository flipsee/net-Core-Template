using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("EmailTemplateEmailGroup")]
    public partial class EmailTemplateEmailGroup : BaseModel
    { 
        public int EmailTemplateId { get; set; }
        public int EmailGroupId { get; set; } 

        [ForeignKey("EmailGroupId")]
        [InverseProperty("EmailTemplateEmailGroups")]
        public EmailGroup EmailGroup { get; set; }
        [ForeignKey("EmailTemplateId")]
        [InverseProperty("EmailTemplateEmailGroups")]
        public EmailTemplate EmailTemplate { get; set; } 
    }
}
