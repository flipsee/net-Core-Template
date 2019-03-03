using App.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Contexts
{
    public class IdentityDbContext : IdentityDbContext<
        AccountUser, AccountRole, int,
        AccountUserClaim, AccountUserRole, AccountUserLogin,
        AccountRoleClaim, AccountUserToken>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AccountUser>(b =>
            {
                b.ToTable("AccountUser");
            });

            builder.Entity<AccountUserClaim>(b =>
            {
                b.ToTable("AccountUserClaim");
            });

            builder.Entity<AccountUserLogin>(b =>
            {
                b.ToTable("AccountUserLogin");
            });

            builder.Entity<AccountUserToken>(b =>
            {
                b.ToTable("AccountUserToken");
            });

            builder.Entity<AccountRole>(b =>
            {
                b.ToTable("AccountRole");
            });

            builder.Entity<AccountRoleClaim>(b =>
            {
                b.ToTable("AccountRoleClaim");
            });

            builder.Entity<AccountUserRole>(b =>
            {
                b.ToTable("AccountUserRole");
            });

        }


    }
}
