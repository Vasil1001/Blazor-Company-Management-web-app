using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tera.Server.Data.Migrations
{
    public partial class Comp_Project_Modify_Entitiesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Project",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Company",
                newName: "CompanyId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedDate",
                table: "Ticket",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "Project",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_CompanyId",
                table: "Project",
                column: "CompanyId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_CompanyId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Project",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Company",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosedDate",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");
        }
    }
}
