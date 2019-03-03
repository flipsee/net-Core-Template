using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infrastructure.Migrations
{
    public partial class init00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "AccountRoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountRoleClaim_AccountRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AccountRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountRoleClaim_AccountRole_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "AccountRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountUserClaim_AccountUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUserClaim_AccountUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountUserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AccountUserLogin_AccountUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUserLogin_AccountUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountUserRole",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true),
                    RoleId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AccountUserRole_AccountRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AccountRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUserRole_AccountRole_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "AccountRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountUserRole_AccountUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUserRole_AccountUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountUserToken",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AccountUserToken_AccountUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUserToken_AccountUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AccountUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AccountRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoleClaim_RoleId",
                table: "AccountRoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoleClaim_RoleId1",
                table: "AccountRoleClaim",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AccountUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AccountUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserClaim_UserId",
                table: "AccountUserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserClaim_UserId1",
                table: "AccountUserClaim",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserLogin_UserId",
                table: "AccountUserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserLogin_UserId1",
                table: "AccountUserLogin",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserRole_RoleId",
                table: "AccountUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserRole_RoleId1",
                table: "AccountUserRole",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserRole_UserId1",
                table: "AccountUserRole",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserToken_UserId1",
                table: "AccountUserToken",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRoleClaim");

            migrationBuilder.DropTable(
                name: "AccountUserClaim");

            migrationBuilder.DropTable(
                name: "AccountUserLogin");

            migrationBuilder.DropTable(
                name: "AccountUserRole");

            migrationBuilder.DropTable(
                name: "AccountUserToken");

            migrationBuilder.DropTable(
                name: "AccountRole");

            migrationBuilder.DropTable(
                name: "AccountUser");
        }
    }
}
