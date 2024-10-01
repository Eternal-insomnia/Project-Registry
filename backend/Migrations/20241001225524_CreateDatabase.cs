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
                    Priority = table.Column<float>(type: "float4", nullable: true),
                    Monitoring = table.Column<string>(type: "text", nullable: true),
                    Activity = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Program = table.Column<string>(type: "text", nullable: true),
                    StrategyBelonging = table.Column<string>(type: "text", nullable: true),
                    RGT = table.Column<string>(type: "char(1)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
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
                    Progress = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Goals = table.Column<int>(type: "integer", nullable: true),
                    Deadlines = table.Column<int>(type: "integer", nullable: true),
                    Budget = table.Column<int>(type: "integer", nullable: true),
                    Contents = table.Column<int>(type: "integer", nullable: true),
                    ReportLink = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ProjectsGoals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Product = table.Column<string>(type: "text", nullable: true),
                    ImplCriteria = table.Column<string>(type: "text", nullable: true),
                    GoalsStatus = table.Column<string>(type: "text", nullable: true),
                    BusinessGoals = table.Column<string>(type: "text", nullable: true),
                    AchieveCriteria = table.Column<string>(type: "text", nullable: true),
                    BusinessGoalsStatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsGoals_ProjectsGeneralInfo_Id",
                        column: x => x.Id,
                        principalTable: "ProjectsGeneralInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsTeam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Customer = table.Column<string>(type: "text", nullable: true),
                    ProductOwner = table.Column<string>(type: "text", nullable: true),
                    Manager = table.Column<string>(type: "text", nullable: true),
                    TeamLead = table.Column<string>(type: "text", nullable: true),
                    BusinessAnalyst = table.Column<string>(type: "text", nullable: true),
                    MCPeople = table.Column<string>(type: "text", nullable: true),
                    Stakeholders = table.Column<string>(type: "text", nullable: true),
                    ExternalPeople = table.Column<string>(type: "text", nullable: true),
                    ADM = table.Column<string>(type: "text", nullable: true),
                    FRC = table.Column<string>(type: "text", nullable: true),
                    BusinessLines = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsTeam_ProjectsGeneralInfo_Id",
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
                name: "ProjectsGoals");

            migrationBuilder.DropTable(
                name: "ProjectsTeam");

            migrationBuilder.DropTable(
                name: "ProjectsGeneralInfo");
        }
    }
}
