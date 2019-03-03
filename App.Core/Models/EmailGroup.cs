using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("EmailGroup")]
    public partial class EmailGroup : BaseModelWithSequence
    {
        public EmailGroup()
        {
            EmailGroupDetails = new HashSet<EmailGroupDetail>(); 
        }

        [Required, StringLength(300)]
        public string Description { get; set; }

        [InverseProperty("EmailGroup")]
        public ICollection<EmailGroupDetail> EmailGroupDetails { get; set; }

        [InverseProperty("EmailGroup")]
        public ICollection<EmailTemplateEmailGroup> EmailTemplateEmailGroups { get; set; }
    }
}
