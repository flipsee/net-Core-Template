using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infrastructure.Migrations.ApplicationDb
{
    public partial class init00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountClaim_AccountClaim_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AccountClaim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    ValueType = table.Column<string>(maxLength: 20, nullable: false),
                    Value = table.Column<string>(maxLength: 200, nullable: true),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    FileName = table.Column<string>(maxLength: 200, nullable: false),
                    FileContent = table.Column<byte[]>(nullable: false),
                    Remark = table.Column<string>(maxLength: 3000, nullable: true),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(maxLength: 300, nullable: false),
                    TableName = table.Column<string>(maxLength: 300, nullable: false),
                    RecordId = table.Column<int>(nullable: true),
                    ColumnName = table.Column<string>(maxLength: 300, nullable: false),
                    OldValue = table.Column<string>(nullable: true),
                    NewValue = table.Column<string>(nullable: true),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogEmail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailTemplateId = table.Column<int>(nullable: true),
                    Recepient = table.Column<string>(maxLength: 500, nullable: false),
                    Subject = table.Column<string>(maxLength: 500, nullable: false),
                    Body = table.Column<string>(nullable: false),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogError",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DbName = table.Column<string>(maxLength: 100, nullable: true),
                    DbServerName = table.Column<string>(maxLength: 100, nullable: true),
                    Url = table.Column<string>(maxLength: 300, nullable: true),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    Message = table.Column<string>(nullable: true),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogError", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Code = table.Column<string>(maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_Lookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    ClaimType = table.Column<string>(maxLength: 100, nullable: true),
                    ClaimValue = table.Column<string>(maxLength: 100, nullable: true),
                    Target = table.Column<string>(maxLength: 20, nullable: true),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    Url = table.Column<string>(maxLength: 300, nullable: true),
                    AddBy = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false),
                    ModBy = table.Column<int>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountClaim_ParentId",
                table: "AccountClaim",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentId",
                table: "Menu",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountClaim");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "LogAudit");

            migrationBuilder.DropTable(
                name: "LogEmail");

            migrationBuilder.DropTable(
                name: "LogError");

            migrationBuilder.DropTable(
                name: "Lookup");

            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
