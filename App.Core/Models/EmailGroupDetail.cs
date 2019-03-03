using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Models
{
    [Table("EmailGroupDetail")]
    public partial class EmailGroupDetail : BaseModelWithSequence
    {
        public int? EmailGroupId { get; set; }
        public int? EmailTemplateId { get; set; }
        [Required, StringLength(3)]
        public string RecepientType { get; set; }
        [Required]
        public bool ExternalUser { get; set; } = false;
        [StringLength(256)]
        public string Email { get; set; }
        public int? UserId { get; set; }
        public int? EmployeeId { get; set; }
                
        [ForeignKey("UserId")]
        public AccountUser User { get; set; }

        [ForeignKey("EmailGroupId")]
        [InverseProperty("EmailGroupDetails")]
        public EmailGroup EmailGroup { get; set; }

        [ForeignKey("EmailTemplateId")]
        [InverseProperty("EmailGroupDetails")]
        public EmailTemplate EmailTemplate { get; set; }
    }
}
