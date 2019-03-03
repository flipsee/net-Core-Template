using System;
using App.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public virtual DbSet<AccountClaim> AccountClaims { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<EmailGroup> EmailGroups { get; set; }
        public virtual DbSet<EmailGroupDetail> EmailGroupDetails { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<EmailTemplateEmailGroup> EmailTemplateEmailGroups { get; set; }
        public virtual DbSet<LogAudit> LogAudits { get; set; }
        public virtual DbSet<LogEmail> LogEmails { get; set; }
        public virtual DbSet<LogError> LogErrors { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }

        //public DbSet<Temp> Temps { get; set; }
    }
}
