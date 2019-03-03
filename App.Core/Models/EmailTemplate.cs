using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("EmailTemplate")]
    public partial class EmailTemplate : BaseModelWithUpdate
    {
        public EmailTemplate()
        {
            EmailGroupDetails = new HashSet<EmailGroupDetail>();
            EmailTemplateEmailGroups = new HashSet<EmailTemplateEmailGroup>();
        }
 
        [Required, StringLength(100)]
        public string Code { get; set; }
        [Required, StringLength(300)]
        public string Description { get; set; }
        [Required, StringLength(500)]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; } 

        [InverseProperty("EmailTemplate")]
        public ICollection<EmailGroupDetail> EmailGroupDetails { get; set; }
        [InverseProperty("EmailTemplate")]
        public ICollection<EmailTemplateEmailGroup> EmailTemplateEmailGroups { get; set; }
    }
}
