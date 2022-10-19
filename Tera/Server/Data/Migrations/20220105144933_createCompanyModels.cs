using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tera.Server.Data.Migrations
{
    public partial class createCompanyModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Ticket",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "DateCreated", "companyDescription", "companyName" },
                values: new object[] { new Guid("1450b96b-b478-4101-9b93-d7b988b90e2d"), new DateTime(2016, 3, 27, 2, 0, 0, 0, DateTimeKind.Unspecified), "Knowledge Ai Limited specializes in Ai innovation and research to help apply it in real life scenarios for companies to benefit marketing wise and on social media.", "Knowledge Ai Limited" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "DateCreated", "companyDescription", "companyName" },
                values: new object[] { new Guid("ce550104-8536-499f-a011-f2882b1cc795"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "Webcast focuses on cloud services that allow users to project content such as screen sharing or video games from their monitors to their living room TV using the hardware of their PC.", "Webcast" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "DateCreated", "companyDescription", "companyName" },
                values: new object[] { new Guid("976b949d-7a17-4060-bddc-a5ed68b84ddd"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "NIO is a Chinese multinational automobile manufacturer headquartered in Shanghai, specializing in designing and developing electric vehicles.", "NIO" });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_UserId",
                table: "Ticket",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_UserId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket");

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("1450b96b-b478-4101-9b93-d7b988b90e2d"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("976b949d-7a17-4060-bddc-a5ed68b84ddd"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("ce550104-8536-499f-a011-f2882b1cc795"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ticket",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
