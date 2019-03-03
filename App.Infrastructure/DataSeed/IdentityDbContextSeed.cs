using App.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.DataSeed
{
    public class IdentityDbContextSeed
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            UserManager<AccountUser> userManager = services.GetRequiredService<UserManager<AccountUser>>();
            RoleManager<AccountRole> roleManager = services.GetRequiredService<RoleManager<AccountRole>>();

            try
            {
                // TODO: Only run this if using a real database
                // context.Database.Migrate();

                if (!userManager.Users.Any())
                {
                    await userManager.CreateAsync(new AccountUser { UserName = "me@mail.com", Email = "me@mail.com" }, "Password1@");
                }

                if (!roleManager.Roles.Any())
                {
                    await roleManager.CreateAsync(new AccountRole { Name = "Admin" });
                }

            }
            catch 
            {
                
            }
        }
    }
}
