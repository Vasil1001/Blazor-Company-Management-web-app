using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Tera.Server.Data.Migrations
{
    public partial class moreEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "DateCreated", "companyDescription", "companyName" },
                values: new object[,]
                {
                    { new Guid("8117bba3-7cf1-4905-bdf1-871b9f8c4aa2"), new DateTime(2016, 3, 27, 2, 0, 0, 0, DateTimeKind.Unspecified), "Knowledge Ai Limited specializes in Ai innovation and research to help apply it in real life scenarios for companies to benefit marketing wise and on social media.", "Knowledge Ai Limited" },
                    { new Guid("d403f98e-d9a7-4eaf-a3ed-995a34055733"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "Webcast focuses on cloud services that allow users to project content such as screen sharing or video games from their monitors to their living room TV using the hardware of their PC.", "Webcast" },
                    { new Guid("279ba4c0-dbec-4be7-9197-d0aee64f67e3"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "NIO is a Chinese multinational automobile manufacturer headquartered in Shanghai, specializing in designing and developing electric vehicles.", "NIO" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "ClosedDate", "CompanyId", "DateCreated", "Description", "Name", "ProjectStatus" },
                values: new object[,]
                {
                    { new Guid("2433f71c-6bc5-4830-8554-c932358bff4a"), null, new Guid("279ba4c0-dbec-4be7-9197-d0aee64f67e3"), new DateTime(2019, 5, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research sensors for self parking", "Self Driving Vehicles Project", "In Progress" },
                    { new Guid("9a87e0bc-33c6-43df-aa03-4cb40ca6393a"), null, new Guid("279ba4c0-dbec-4be7-9197-d0aee64f67e3"), new DateTime(2020, 3, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research effective methods for battery efficiency, including stations for battery swapping, leaving your battery to charge for others to swap with", "Battery efficiency Project", "In Progress" },
                    { new Guid("efeedf3a-f4bf-49f4-bad4-2445981db0e9"), null, new Guid("8117bba3-7cf1-4905-bdf1-871b9f8c4aa2"), new DateTime(2021, 6, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Research Neural Networks for stock market trend analysis", "Neural Networks research", "In Progress" },
                    { new Guid("e42423b2-10ac-4671-8852-0cf5a436a3a6"), null, new Guid("d403f98e-d9a7-4eaf-a3ed-995a34055733"), new DateTime(2021, 9, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Bayesian networks are a type of probabilistic graphical model that uses Bayesian inference for probability computations.", "Bayesian Networks", "Open" },
                    { new Guid("1c8f40e5-b55f-4c4b-8bb4-1641b34786a4"), null, new Guid("8117bba3-7cf1-4905-bdf1-871b9f8c4aa2"), new DateTime(2017, 9, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Research on: Machine learning is an application of artificial intelligence (AI) that provides systems the ability to automatically learn and improve from experience without being explicitly programmed.", "Machine Learning", "Closed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("279ba4c0-dbec-4be7-9197-d0aee64f67e3"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("8117bba3-7cf1-4905-bdf1-871b9f8c4aa2"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("d403f98e-d9a7-4eaf-a3ed-995a34055733"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("1c8f40e5-b55f-4c4b-8bb4-1641b34786a4"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("2433f71c-6bc5-4830-8554-c932358bff4a"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("9a87e0bc-33c6-43df-aa03-4cb40ca6393a"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("e42423b2-10ac-4671-8852-0cf5a436a3a6"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("efeedf3a-f4bf-49f4-bad4-2445981db0e9"));

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
                values: new object[] { new Guid("39ffd8ff-cc2a-4542-bd56-289a5e41b3e3"), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 5, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research sensors for self parking", "Self Driving Vehicles", "Open" });
        }
    }
}
