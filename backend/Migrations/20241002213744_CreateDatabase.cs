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
                name: "ProjectsCost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Profitability = table.Column<string>(type: "text", nullable: true),
                    PreCAPEXExt = table.Column<float>(type: "real", nullable: true),
                    PreCAPEXWF = table.Column<float>(type: "real", nullable: true),
                    PreOPEX = table.Column<float>(type: "real", nullable: true),
                    PreCAPEXExtActual = table.Column<float>(type: "real", nullable: true),
                    PreCAPEXExtDeltaPercent = table.Column<float>(type: "real", nullable: true),
                    BaseCAPEXExt = table.Column<float>(type: "real", nullable: true),
                    BaseCAPEXWF = table.Column<float>(type: "real", nullable: true),
                    BaseOPEX = table.Column<float>(type: "real", nullable: true),
                    PassportCAPEXExt = table.Column<float>(type: "real", nullable: true),
                    PassportCAPEXWF = table.Column<float>(type: "real", nullable: true),
                    PassportOPEX = table.Column<float>(type: "real", nullable: true),
                    PassportCAPEXExtDelta = table.Column<float>(type: "real", nullable: true),
                    PassportCAPEXExtDeltaPercent = table.Column<float>(type: "real", nullable: true),
                    ActualCAPEXExt = table.Column<float>(type: "real", nullable: true),
                    ActualCAPEXWF = table.Column<float>(type: "real", nullable: true),
                    ActualOPEX = table.Column<float>(type: "real", nullable: true),
                    ActualCAPEXExtDelta = table.Column<float>(type: "real", nullable: true),
                    ActualCAPEXExtDeltaPercent = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsCost_ProjectsGeneralInfo_Id",
                        column: x => x.Id,
                        principalTable: "ProjectsGeneralInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PrePStartDecision = table.Column<string>(type: "text", nullable: true),
                    ImplStartDecision = table.Column<string>(type: "text", nullable: true),
                    Timelines = table.Column<string>(type: "text", nullable: true),
                    ReasonCRTimelines = table.Column<string>(type: "text", nullable: true),
                    Budget = table.Column<string>(type: "text", nullable: true),
                    ReasonCRBudget = table.Column<string>(type: "text", nullable: true),
                    Contents = table.Column<string>(type: "text", nullable: true),
                    ReasonCRContents = table.Column<string>(type: "text", nullable: true),
                    StopResumeDecision = table.Column<string>(type: "text", nullable: true),
                    StopReason = table.Column<string>(type: "text", nullable: true),
                    CloseCompleteDecision = table.Column<string>(type: "text", nullable: true),
                    CloseReason = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsDocuments_ProjectsGeneralInfo_Id",
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

            migrationBuilder.CreateTable(
                name: "ProjectsTimelines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PreStart = table.Column<DateOnly>(type: "date", nullable: true),
                    PreEndActual = table.Column<DateOnly>(type: "date", nullable: true),
                    PreDuration = table.Column<int>(type: "integer", nullable: true),
                    PreEndPlanned = table.Column<DateOnly>(type: "date", nullable: true),
                    PreDeviation = table.Column<int>(type: "integer", nullable: true),
                    ActualStart = table.Column<DateOnly>(type: "date", nullable: true),
                    ActualEnd = table.Column<DateOnly>(type: "date", nullable: true),
                    ActualDuration = table.Column<int>(type: "integer", nullable: true),
                    BaseStart = table.Column<DateOnly>(type: "date", nullable: true),
                    BaseEnd = table.Column<DateOnly>(type: "date", nullable: true),
                    BaseDeviation = table.Column<int>(type: "integer", nullable: true),
                    PassportEnd = table.Column<DateOnly>(type: "date", nullable: true),
                    PassportDeviation = table.Column<int>(type: "integer", nullable: true),
                    PassportStartYear = table.Column<int>(type: "integer", nullable: true),
                    PassportEndYear = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsTimelines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectsTimelines_ProjectsGeneralInfo_Id",
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
                name: "ProjectsCost");

            migrationBuilder.DropTable(
                name: "ProjectsDocuments");

            migrationBuilder.DropTable(
                name: "ProjectsGoals");

            migrationBuilder.DropTable(
                name: "ProjectsTeam");

            migrationBuilder.DropTable(
                name: "ProjectsTimelines");

            migrationBuilder.DropTable(
                name: "ProjectsGeneralInfo");
        }
    }
}
