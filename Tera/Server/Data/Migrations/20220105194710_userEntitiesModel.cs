using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Tera.Server.Data.Migrations
{
    public partial class userEntitiesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("7253564b-80d4-4a23-9be5-4306ed95d758"), new DateTime(2016, 3, 27, 2, 0, 0, 0, DateTimeKind.Unspecified), "Knowledge Ai Limited specializes in Ai innovation and research to help apply it in real life scenarios for companies to benefit marketing wise and on social media.", "Knowledge Ai Limited" },
                    { new Guid("8c50e5fa-77fc-435b-8d1e-e8f8239a925e"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "Webcast focuses on cloud services that allow users to project content such as screen sharing or video games from their monitors to their living room TV using the hardware of their PC.", "Webcast" },
                    { new Guid("8024dff7-2a40-45ae-b732-74e5b074a640"), new DateTime(2018, 6, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "NIO is a Chinese multinational automobile manufacturer headquartered in Shanghai, specializing in designing and developing electric vehicles.", "NIO" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "ClosedDate", "CompanyId", "DateCreated", "Description", "Name", "ProjectStatus" },
                values: new object[,]
                {
                    { new Guid("03e2a4b2-906a-40c9-970d-fad4d46d068e"), null, new Guid("8024dff7-2a40-45ae-b732-74e5b074a640"), new DateTime(2019, 5, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research sensors for self parking", "Self Driving Vehicles Project", "In Progress" },
                    { new Guid("4b5705e4-6ba1-4605-90bd-69f9f450a3c8"), null, new Guid("8024dff7-2a40-45ae-b732-74e5b074a640"), new DateTime(2020, 3, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research effective methods for battery efficiency, including stations for battery swapping, leaving your battery to charge for others to swap with", "Battery efficiency Project", "In Progress" },
                    { new Guid("7b824651-8b2b-421d-9c51-7826c6643787"), null, new Guid("7253564b-80d4-4a23-9be5-4306ed95d758"), new DateTime(2021, 6, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Research Neural Networks for stock market trend analysis", "Neural Networks research", "In Progress" },
                    { new Guid("5d54274c-987d-4b04-9886-4b7888ca4223"), null, new Guid("7253564b-80d4-4a23-9be5-4306ed95d758"), new DateTime(2021, 9, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Bayesian networks are a type of probabilistic graphical model that uses Bayesian inference for probability computations.", "Bayesian Networks", "Open" },
                    { new Guid("4bde0f2e-7f2e-4f2c-a4cf-96a2f7e59ec8"), null, new Guid("8c50e5fa-77fc-435b-8d1e-e8f8239a925e"), new DateTime(2017, 9, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Research on: Machine learning is an application of artificial intelligence (AI) that provides systems the ability to automatically learn and improve from experience without being explicitly programmed.", "Machine Learning", "Closed" }
                });
            migrationBuilder.InsertData(
    table: "User",
    columns: new[] { "UserId", "Email", "FirstName", "LastName" },
    values: new object[,]
    {
                    { new Guid("476c5eaf-895b-434f-9002-cd49e3c289d3"), "George@gmail.com", "George", "Rowling" },
                    { new Guid("18aafc1f-4704-4a60-a9d7-58f6e9811c0e"), "jron@gmail.com", "Jimmy", "Ronald" },
                    { new Guid("a8eb5f66-7934-4122-aa7e-252a2e9654f9"), "aj@gmail.com", "Andy", "Jermaine" }

    });
            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "ClosedDate", "Description", "Name", "TicketCreatedDate", "TicketStatus", "UserId" },
                values: new object[,]
                {
                    { new Guid("497fab3b-0b3a-4083-b5ce-c18b8aa45c38"), null, "Research hydrogen batteries long term effect on electric cars and compare to current lithium used by NIO", "Research hydrogen batteries long term effect on electric cars", new DateTime(2021, 9, 28, 2, 0, 0, 0, DateTimeKind.Unspecified), "In Progress", new Guid("476c5eaf-895b-434f-9002-cd49e3c289d3") },
                    { new Guid("dca351dc-19b6-44d1-90b2-beefd26cd37f"), null, "Research Bayesian networks making a summary for our architecture", "Work on Bayesian networks", new DateTime(202, 11, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "In Progress", new Guid("18aafc1f-4704-4a60-a9d7-58f6e9811c0e") },
                    { new Guid("8bd110c8-2a0d-4d2f-8ad1-7278c326ae53"), null, "Work on the cloud service streaming to remote screens", "Webcast cloud service ", new DateTime(2021, 12, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Open", new Guid("a8eb5f66-7934-4122-aa7e-252a2e9654f9") }
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("7253564b-80d4-4a23-9be5-4306ed95d758"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("8024dff7-2a40-45ae-b732-74e5b074a640"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: new Guid("8c50e5fa-77fc-435b-8d1e-e8f8239a925e"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("03e2a4b2-906a-40c9-970d-fad4d46d068e"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("4b5705e4-6ba1-4605-90bd-69f9f450a3c8"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("4bde0f2e-7f2e-4f2c-a4cf-96a2f7e59ec8"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("5d54274c-987d-4b04-9886-4b7888ca4223"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("7b824651-8b2b-421d-9c51-7826c6643787"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("497fab3b-0b3a-4083-b5ce-c18b8aa45c38"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("8bd110c8-2a0d-4d2f-8ad1-7278c326ae53"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("dca351dc-19b6-44d1-90b2-beefd26cd37f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("18aafc1f-4704-4a60-a9d7-58f6e9811c0e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("476c5eaf-895b-434f-9002-cd49e3c289d3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("a8eb5f66-7934-4122-aa7e-252a2e9654f9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("e8316350-2f57-47f8-bb76-e12d280c601d"));

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
                    { new Guid("2433f71c-6bc5-4830-8554-c932358bff4a"), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 5, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research sensors for self parking", "Self Driving Vehicles Project", "In Progress" },
                    { new Guid("9a87e0bc-33c6-43df-aa03-4cb40ca6393a"), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 3, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "Research effective methods for battery efficiency, including stations for battery swapping, leaving your battery to charge for others to swap with", "Battery efficiency Project", "In Progress" },
                    { new Guid("efeedf3a-f4bf-49f4-bad4-2445981db0e9"), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 6, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Research Neural Networks for stock market trend analysis", "Neural Networks research", "In Progress" },
                    { new Guid("e42423b2-10ac-4671-8852-0cf5a436a3a6"), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 9, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Bayesian networks are a type of probabilistic graphical model that uses Bayesian inference for probability computations.", "Bayesian Networks", "Open" },
                    { new Guid("1c8f40e5-b55f-4c4b-8bb4-1641b34786a4"), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2017, 9, 2, 3, 0, 0, 0, DateTimeKind.Unspecified), "Research on: Machine learning is an application of artificial intelligence (AI) that provides systems the ability to automatically learn and improve from experience without being explicitly programmed.", "Machine Learning", "Closed" }
                });
        }
    }
}
