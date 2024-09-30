using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
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

            migrationBuilder.CreateTable(
                name: "ProjectsCondition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Progress = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Goals = table.Column<int>(type: "integer", nullable: false),
                    Deadlines = table.Column<int>(type: "integer", nullable: false),
                    Budget = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<int>(type: "integer", nullable: false),
                    ReportLink = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsCondition_ProjectsGeneralInfo_Id",
                        column: x => x.Id,
                        principalTable: "ProjectsGeneralInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectsCondition");

            migrationBuilder.DropTable(
                name: "ProjectsGeneralInfo");
        }
    }
}
