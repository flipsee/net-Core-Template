﻿// <auto-generated />
using System;
using App.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Infrastructure.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190214030012_0")]
    partial class _0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Core.Models.AccountClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Disabled");

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<int?>("ParentId");

                    b.Property<int>("Sequence");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Value")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("AccountClaim");
                });

            modelBuilder.Entity("App.Core.Models.AccountUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AccountUser");
                });

            modelBuilder.Entity("App.Core.Models.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Disabled");

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<string>("Value")
                        .HasMaxLength(200);

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("App.Core.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<bool>("Disabled");

                    b.Property<byte[]>("FileContent")
                        .IsRequired();

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<string>("Remark")
                        .HasMaxLength(3000);

                    b.Property<int>("Sequence");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("App.Core.Models.EmailGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<bool>("Disabled");

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<int>("Sequence");

                    b.HasKey("Id");

                    b.ToTable("EmailGroup");
                });

            modelBuilder.Entity("App.Core.Models.EmailGroupDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<int?>("EmailGroupId");

                    b.Property<int?>("EmailTemplateId");

                    b.Property<int?>("EmployeeId");

                    b.Property<bool>("ExternalUser");

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<string>("RecepientType")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("Sequence");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EmailGroupId");

                    b.HasIndex("EmailTemplateId");

                    b.HasIndex("UserId");

                    b.ToTable("EmailGroupDetail");
                });

            modelBuilder.Entity("App.Core.Models.EmailTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<bool>("Disabled");

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("App.Core.Models.EmailTemplateEmailGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<int>("EmailGroupId");

                    b.Property<int>("EmailTemplateId");

                    b.HasKey("Id");

                    b.HasIndex("EmailGroupId");

                    b.HasIndex("EmailTemplateId");

                    b.ToTable("EmailTemplateEmailGroup");
                });

            modelBuilder.Entity("App.Core.Models.LogAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("ColumnName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("NewValue");

                    b.Property<string>("OldValue");

                    b.Property<int?>("RecordId");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("LogAudit");
                });

            modelBuilder.Entity("App.Core.Models.LogEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<int?>("EmailTemplateId");

                    b.Property<string>("Recepient")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("LogEmail");
                });

            modelBuilder.Entity("App.Core.Models.LogError", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("DbName")
                        .HasMaxLength(100);

                    b.Property<string>("DbServerName")
                        .HasMaxLength(100);

                    b.Property<string>("Message");

                    b.Property<string>("Source")
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("LogError");
                });

            modelBuilder.Entity("App.Core.Models.Lookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<bool>("Disabled");

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<int>("Sequence");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Lookup");
                });

            modelBuilder.Entity("App.Core.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("AddDate");

                    b.Property<string>("ClaimType")
                        .HasMaxLength(100);

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasMaxLength(50);

                    b.Property<string>("ModBy")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("ModDate");

                    b.Property<int?>("ParentId");

                    b.Property<int>("Sequence");

                    b.Property<string>("Target")
                        .HasMaxLength(20);

                    b.Property<string>("Url")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("App.Core.Models.AccountClaim", b =>
                {
                    b.HasOne("App.Core.Models.AccountClaim", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("App.Core.Models.EmailGroupDetail", b =>
                {
                    b.HasOne("App.Core.Models.EmailGroup", "EmailGroup")
                        .WithMany("EmailGroupDetails")
                        .HasForeignKey("EmailGroupId");

                    b.HasOne("App.Core.Models.EmailTemplate", "EmailTemplate")
                        .WithMany("EmailGroupDetails")
                        .HasForeignKey("EmailTemplateId");

                    b.HasOne("App.Core.Models.AccountUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("App.Core.Models.EmailTemplateEmailGroup", b =>
                {
                    b.HasOne("App.Core.Models.EmailGroup", "EmailGroup")
                        .WithMany("EmailTemplateEmailGroups")
                        .HasForeignKey("EmailGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Core.Models.EmailTemplate", "EmailTemplate")
                        .WithMany("EmailTemplateEmailGroups")
                        .HasForeignKey("EmailTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Core.Models.Menu", b =>
                {
                    b.HasOne("App.Core.Models.Menu", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
