using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infrastructure.Migrations.ApplicationDb
{
    public partial class _0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "Menu",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "Menu",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "Lookup",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "Lookup",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "LogError",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "LogEmail",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "LogAudit",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "EmailTemplateEmailGroup",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "EmailTemplate",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "EmailTemplate",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "EmailGroupDetail",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "EmailGroupDetail",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "EmailGroup",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "EmailGroup",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "Document",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "Document",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "Configuration",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "Configuration",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ModBy",
                table: "AccountClaim",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "AccountClaim",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "Menu",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "Menu",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "Lookup",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "Lookup",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "LogError",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "LogEmail",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "LogAudit",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "EmailTemplateEmailGroup",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "EmailTemplate",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "EmailTemplate",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "EmailGroupDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "EmailGroupDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "EmailGroup",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "EmailGroup",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "Document",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "Document",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "Configuration",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "Configuration",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "ModBy",
                table: "AccountClaim",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "AddBy",
                table: "AccountClaim",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);
        }
    }
}
