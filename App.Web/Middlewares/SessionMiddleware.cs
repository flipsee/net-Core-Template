using App.Core.Models;
using App.Core.Sessions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Middlewares
{
    public class SessionMiddleware
    {
        private readonly RequestDelegate next;

        public SessionMiddleware(RequestDelegate next)
        {
            this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context, SessionProvider sessionProvider, UserManager<AccountUser> userManager)
        { 
            await next(context);

            var user = await userManager.GetUserAsync(context.User);

            if (user != null)
            {
                sessionProvider.Initialise(user);
            }
        }
    }
}
