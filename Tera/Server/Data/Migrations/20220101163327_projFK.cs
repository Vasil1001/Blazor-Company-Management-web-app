using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tera.Server.Data.Migrations
{
    public partial class projFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Company_CompanyId",
                table: "Project");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "Project",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Company_CompanyId",
                table: "Project",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Company_CompanyId",
                table: "Project");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "Project",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Company_CompanyId",
                table: "Project",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
