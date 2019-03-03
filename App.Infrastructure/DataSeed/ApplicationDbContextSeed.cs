using App.Core.Models;
using App.Infrastructure.Contexts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.DataSeed
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext ctx, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                // TODO: Only run this if using a real database
                // context.Database.Migrate();

                if (!ctx.Menus.Any())
                {
                    ctx.Menus.AddRange(GetMenuSeed());
                    await ctx.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<ApplicationDbContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(ctx, loggerFactory, retryForAvailability);
                }
            }
        }

        private static IEnumerable<Menu> GetMenuSeed()
        {
            return new List<Menu>()
            {
                new Menu() { Description = "Modules", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now},
                new Menu() { Description = "Reports", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now },
                new Menu() { Description = "Master Data", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now },
                new Menu() { Description = "Maintenance", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now
                            ,Children = new List<Menu>(){
                                new Menu() { Description = "Menus", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now }
                            }},
                new Menu() { Description = "User & Security", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now
                            ,Children = new List<Menu>(){
                                new Menu() { Description = "Users", AddBy = "SYSTEM", AddDate = DateTime.Now, ModBy = "SYSTEM", ModDate= DateTime.Now }
                            } }
            };
        }
    }
}
