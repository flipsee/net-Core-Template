using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Sessions
{
    public class Session
    {
        public AccountUser User { get; set; }

        public int? UserId { get; set; }

        public string UserName { get; set; }

        //public Tenant Tenant { get; set; }

        //public int? TenantId { get; set; }

        //public string Subdomain { get; set; }
    }
}
