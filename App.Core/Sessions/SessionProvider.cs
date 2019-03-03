using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Sessions
{
    public class SessionProvider
    {
        public Session session;

        public SessionProvider()
        {
            session = new Session();
        }

        public void Initialise(AccountUser user)
        {
            session.User = user;
            session.UserId = user.Id;
            session.UserName = user.UserName;
            //Session.Tenant = user.Tenant;
            //Session.TenantId = user.TenantId;
            //Session.Subdomain = user.Tenant.HostName;
        }
    }
}
