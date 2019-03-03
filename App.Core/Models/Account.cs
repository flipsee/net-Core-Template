using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace App.Core.Models
{
    public class AccountUser : IdentityUser<int>
    {
        //public virtual ICollection<AccountUserClaim> Claims { get; set; }
        //public virtual ICollection<AccountUserLogin> Logins { get; set; }
        //public virtual ICollection<AccountUserToken> Tokens { get; set; }
        //public virtual ICollection<AccountUserRole> UserRoles { get; set; }
    }

    public class AccountRole : IdentityRole<int>
    {
        //public virtual ICollection<AccountUserRole> UserRoles { get; set; }
        //public virtual ICollection<AccountRoleClaim> RoleClaims { get; set; }
    }

    public class AccountUserRole : IdentityUserRole<int>
    {
        //public virtual AccountUser User { get; set; }
        //public virtual AccountRole Role { get; set; }
    }

    public class AccountUserClaim : IdentityUserClaim<int>
    {
        //public virtual AccountUser User { get; set; }
        [StringLength(100)]
        public override string ClaimType { get; set; }
        [StringLength(100)]
        public override string ClaimValue { get; set; }
    }

    public class AccountUserLogin : IdentityUserLogin<int>
    {
        //public virtual AccountUser User { get; set; }
    }

    public class AccountRoleClaim : IdentityRoleClaim<int>
    {
        //public virtual AccountRole Role { get; set; }
        [StringLength(100)]
        public override string ClaimType { get; set; }
        [StringLength(100)]
        public override string ClaimValue { get; set; }
    }

    public class AccountUserToken : IdentityUserToken<int>
    {
        //public virtual AccountUser User { get; set; }
    }
}
