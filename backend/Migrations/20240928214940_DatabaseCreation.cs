using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsentCode.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectsGeneralInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Year = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Stage = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsGeneralInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjectsGeneralInfo",
                columns: new[] { "Id", "Code", "Name", "Priority", "Stage", "Status", "Year" },
                values: new object[,]
                {
                    { new Guid("e251e391-9443-4a26-915e-72e5752ed6e7"), "COC1", "Web App", 7f, "In Progress", "Archived", "24" },
                    { new Guid("eb923634-0435-4db8-a34b-5cad1ada6ccd"), "preCOC", "Game", 3f, "Done", "Archived", "23" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectsGeneralInfo");
        }
    }
}
