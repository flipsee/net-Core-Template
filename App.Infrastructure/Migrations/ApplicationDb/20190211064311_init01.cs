using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infrastructure.Migrations.ApplicationDb
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.CreateTable(
                name: "AccountUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUser", x => x.Id);
                });
                */
            migrationBuilder.CreateTable(
                name: "EmailGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Subject = table.Column<string>(maxLength: 500, nullable: false),
                    Body = table.Column<string>(nullable: false),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailGroupDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailGroupId = table.Column<int>(nullable: true),
                    EmailTemplateId = table.Column<int>(nullable: true),
                    RecepientType = table.Column<string>(maxLength: 3, nullable: false),
                    ExternalUser = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailGroupDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailGroupDetail_EmailGroup_EmailGroupId",
                        column: x => x.EmailGroupId,
                        principalTable: "EmailGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailGroupDetail_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailGroupDetail_AccountUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplateEmailGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailTemplateId = table.Column<int>(nullable: false),
                    EmailGroupId = table.Column<int>(nullable: false),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplateEmailGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTemplateEmailGroup_EmailGroup_EmailGroupId",
                        column: x => x.EmailGroupId,
                        principalTable: "EmailGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailTemplateEmailGroup_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailGroupDetail_EmailGroupId",
                table: "EmailGroupDetail",
                column: "EmailGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailGroupDetail_EmailTemplateId",
                table: "EmailGroupDetail",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailGroupDetail_UserId",
                table: "EmailGroupDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplateEmailGroup_EmailGroupId",
                table: "EmailTemplateEmailGroup",
                column: "EmailGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplateEmailGroup_EmailTemplateId",
                table: "EmailTemplateEmailGroup",
                column: "EmailTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailGroupDetail");

            migrationBuilder.DropTable(
                name: "EmailTemplateEmailGroup");
            /*
            migrationBuilder.DropTable(
                name: "AccountUser");
                */
            migrationBuilder.DropTable(
                name: "EmailGroup");

            migrationBuilder.DropTable(
                name: "EmailTemplate");
        }
    }
}
