using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Tera.Server.Data.Migrations
{
    public partial class projectModelOnLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "DateCreated", "companyDescription", "companyName" },
                values: new object[,]
                {
                    { new Guid("efe97b21-20f9-4ae2-a23e-4a761d4ba685"), new DateTime(2016, 3, 27, 2, 0, 0, 0, DateTimeKind.Unspecified), "Knowledge Ai Limited specializes in Ai innovation and research to help apply it in real life scenarios for companies to benefit marketing wise and on social media.", "Knowledge Ai Limited" },
                    { new Guid("ec9651ea-551e-4bb8-8a1e-87582e4c60ad"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "Webcast focuses on cloud services that allow users to project content such as screen sharing or video games from their monitors to their living room TV using the hardware of their PC.", "Webcast" },
                    { new Guid("3d2a9c68-6bbe-4a51-9ab1-5874f6e24407"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "NIO is a Chinese multinational automobile manufacturer headquartered in Shanghai, specializing in designing and developing electric vehicles.", "NIO" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "ClosedDate", "CompanyId", "DateCreated", "Description", "Name", "ProjectStatus" },
                values: new object[] { new Guid("39ffd8ff-cc2a-4542-bd56-289a5e41b3e3"), null, new Guid("3d2a9c68-6bbe-4a51-9ab1-5874f6e24407"), new DateTime(2019, 5, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research sensors for self parking", "Self Driving Vehicles", "Open" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("3d2a9c68-6bbe-4a51-9ab1-5874f6e24407"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("ec9651ea-551e-4bb8-8a1e-87582e4c60ad"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("efe97b21-20f9-4ae2-a23e-4a761d4ba685"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("39ffd8ff-cc2a-4542-bd56-289a5e41b3e3"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Project",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
