using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsentCode.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectsGeneralInfo",
                keyColumn: "Id",
                keyValue: new Guid("e251e391-9443-4a26-915e-72e5752ed6e7"));

            migrationBuilder.DeleteData(
                table: "ProjectsGeneralInfo",
                keyColumn: "Id",
                keyValue: new Guid("eb923634-0435-4db8-a34b-5cad1ada6ccd"));

            migrationBuilder.InsertData(
                table: "ProjectsGeneralInfo",
                columns: new[] { "Id", "Code", "Name", "Priority", "Stage", "Status", "Year" },
                values: new object[,]
                {
                    { new Guid("36305a06-e9fd-43a5-bc25-30d7f334769b"), "preCOC", "Game", 3f, "Done", "Archived", "23" },
                    { new Guid("a5ca0a66-3408-490d-af33-b8fdfff280f7"), "COC1", "Web App", 7f, "In Progress", "Archived", "24" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectsGeneralInfo",
                keyColumn: "Id",
                keyValue: new Guid("36305a06-e9fd-43a5-bc25-30d7f334769b"));

            migrationBuilder.DeleteData(
                table: "ProjectsGeneralInfo",
                keyColumn: "Id",
                keyValue: new Guid("a5ca0a66-3408-490d-af33-b8fdfff280f7"));

            migrationBuilder.InsertData(
                table: "ProjectsGeneralInfo",
                columns: new[] { "Id", "Code", "Name", "Priority", "Stage", "Status", "Year" },
                values: new object[,]
                {
                    { new Guid("e251e391-9443-4a26-915e-72e5752ed6e7"), "COC1", "Web App", 7f, "In Progress", "Archived", "24" },
                    { new Guid("eb923634-0435-4db8-a34b-5cad1ada6ccd"), "preCOC", "Game", 3f, "Done", "Archived", "23" }
                });
        }
    }
}
