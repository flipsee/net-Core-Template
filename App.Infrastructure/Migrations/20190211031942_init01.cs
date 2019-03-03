using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infrastructure.Migrations
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountRoleClaim_AccountRole_RoleId1",
                table: "AccountRoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountUserClaim_AccountUser_UserId1",
                table: "AccountUserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountUserLogin_AccountUser_UserId1",
                table: "AccountUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountUserRole_AccountRole_RoleId1",
                table: "AccountUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountUserRole_AccountUser_UserId1",
                table: "AccountUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountUserToken_AccountUser_UserId1",
                table: "AccountUserToken");

            migrationBuilder.DropIndex(
                name: "IX_AccountUserToken_UserId1",
                table: "AccountUserToken");

            migrationBuilder.DropIndex(
                name: "IX_AccountUserRole_RoleId1",
                table: "AccountUserRole");

            migrationBuilder.DropIndex(
                name: "IX_AccountUserRole_UserId1",
                table: "AccountUserRole");

            migrationBuilder.DropIndex(
                name: "IX_AccountUserLogin_UserId1",
                table: "AccountUserLogin");

            migrationBuilder.DropIndex(
                name: "IX_AccountUserClaim_UserId1",
                table: "AccountUserClaim");

            migrationBuilder.DropIndex(
                name: "IX_AccountRoleClaim_RoleId1",
                table: "AccountRoleClaim");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AccountUserToken");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "AccountUserRole");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AccountUserRole");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AccountUserLogin");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AccountUserClaim");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "AccountRoleClaim");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "AccountUserToken",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "AccountUserRole",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "AccountUserRole",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "AccountUserLogin",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "AccountUserClaim",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "AccountRoleClaim",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserToken_UserId1",
                table: "AccountUserToken",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserRole_RoleId1",
                table: "AccountUserRole",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserRole_UserId1",
                table: "AccountUserRole",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserLogin_UserId1",
                table: "AccountUserLogin",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUserClaim_UserId1",
                table: "AccountUserClaim",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoleClaim_RoleId1",
                table: "AccountRoleClaim",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountRoleClaim_AccountRole_RoleId1",
                table: "AccountRoleClaim",
                column: "RoleId1",
                principalTable: "AccountRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountUserClaim_AccountUser_UserId1",
                table: "AccountUserClaim",
                column: "UserId1",
                principalTable: "AccountUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountUserLogin_AccountUser_UserId1",
                table: "AccountUserLogin",
                column: "UserId1",
                principalTable: "AccountUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountUserRole_AccountRole_RoleId1",
                table: "AccountUserRole",
                column: "RoleId1",
                principalTable: "AccountRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountUserRole_AccountUser_UserId1",
                table: "AccountUserRole",
                column: "UserId1",
                principalTable: "AccountUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountUserToken_AccountUser_UserId1",
                table: "AccountUserToken",
                column: "UserId1",
                principalTable: "AccountUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
