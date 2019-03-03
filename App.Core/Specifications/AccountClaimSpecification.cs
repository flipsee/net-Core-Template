using App.Core.Models;

namespace App.Core.Specifications
{
    public class AccountClaimSpecification : BaseSpecification<AccountClaim>
    {
        public AccountClaimSpecification(int skip, int take, string type, string value, string description)
               : base(i => (type != "" || i.Type.Contains(type)) &&
                           (value != "" || i.Value.Contains(value)) &&
                           (description != "" || i.Description.Contains(description))
                    )
        {
            ApplyPaging(skip, take);
        }
    }
}
