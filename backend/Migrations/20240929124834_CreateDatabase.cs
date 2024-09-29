using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsentCode.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
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
                    Priority = table.Column<float>(type: "float4", nullable: false),
                    Monitoring = table.Column<string>(type: "text", nullable: true),
                    Activity = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Program = table.Column<string>(type: "text", nullable: true),
                    StrategyBelonging = table.Column<string>(type: "text", nullable: true),
                    RGT = table.Column<string>(type: "char(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsGeneralInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjectsGeneralInfo",
                columns: new[] { "Id", "Activity", "Category", "Code", "Monitoring", "Name", "Priority", "Program", "RGT", "Stage", "Status", "StrategyBelonging", "Year" },
                values: new object[,]
                {
                    { new Guid("15a84b93-e3a6-4bd0-9130-e9cddfe42328"), null, null, "preCOC", null, "Game", 3f, null, null, "Done", "Archived", null, "23" },
                    { new Guid("b7eadf4f-e161-42fe-9db6-9f906432025f"), null, null, "COC1", null, "Web App", 7f, null, null, "In Progress", "Archived", null, "24" }
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
