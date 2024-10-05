CREATE TABLE "ProjectGeneralInfo" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Year" text,
    "Status" text,
    "Code" text,
    "Name" text,
    "Stage" text,
    "Priority" text,
    "PostMonitoring" text,
    "Activity" text,    
    "Category" text,
    "Program" text,
    "StrategyBelonging" text,
    "RGT" text,
    "Description" text,
    "Dependencies" text
);

CREATE TABLE "ProjectCondition" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Progress" text,
    "GeneralStatus" text,
    "Goals" text,
    "Timelines" text,
    "Budget" text,
    "Contents" text,
    "ReportLink" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectTeam" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Customer" text,
    "ProductOwner" text,
    "Manager" text,
    "TeamLead" text,
    "BusinessAnalyst" text,
    "MCPeople" text,
    "Stakeholders" text,
    "ExternalPeople" text,
    "ADM" text,
    "FRC" text,
    "BusinessLines" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectTimelines" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "PreStart" text,
    "PreEndActual" text,
    "PreDuration" text,
    "PreEndPlanned" text,
    "PreDeviation" text,
    "ActualStart" text,
    "ActualEnd" text,
    "ActualDuration" text,
    "BaseStart" text,
    "BaseEnd" text,
    "BaseDeviation" text,
    "PassportEnd" text,
    "PassportDeviation" text,
    "PassportStartYear" text,
    "PassportEndYear" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectCost" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Profitability" text,
    "PreCAPEXExt" text,
    "PreCAPEXWF" text,
    "PreOPEX" text,
    "PreCAPEXExtActual" text,
    "PreCAPEXExtDeltaPercent" text,
    "BaseCAPEXExt" text,
    "BaseCAPEXWF" text,
    "BaseOPEX" text,
    "PassportCAPEXExt" text,
    "PassportCAPEXWF" text,
    "PassportOPEX" text,
    "PassportCAPEXExtDelta" text,
    "PassportCAPEXExtDeltaPercent" text,
    "ActualCAPEXExt" text,
    "ActualCAPEXWF" text,
    "ActualOPEX" text,
    "ActualCAPEXExtDelta" text,
    "ActualCAPEXExtDeltaPercent" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectDocuments" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "PrePStartDecision" text,
    "ImplStartDecision" text,
    "Timelines" text,
    "ReasonCRTimelines" text,
    "Budget" text,
    "ReasonCRBudget" text,
    "Contents" text,
    "ReasonCRContents" text,
    "StopResumeDecision" text,
    "StopReason" text,
    "CloseCompleteDecision" text,
    "CloseReason" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);


CREATE TABLE "ProjectGoals" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Product" text,
    "ImplCriteria" text,
    "GoalsStatus" text,
    "BusinessGoals" text,
    "AchieveCriteria" text,
    "BusinessGoalsStatus" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectMonitoring" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Sign" text,
    "MonitoringStatus" text,
    "EndYear" text,
    "Product" text,
    "Manager" text,
    "Characteristics" text,
    "ShortName" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE VIEW "HomeView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage", COALESCE("Priority", '') AS "Priority",
    COALESCE("Progress", '') AS "Progress", COALESCE("GeneralStatus", '') AS "GeneralStatus",
    COALESCE("ActualEnd", '') AS "ActualEnd", COALESCE("Manager", '') AS "Manager",
    COALESCE("Description", '') AS "Description"
    FROM "ProjectGeneralInfo"
    JOIN "ProjectCondition" ON "ProjectGeneralInfo"."Id" = "ProjectCondition"."Id"
    JOIN "ProjectTimelines" ON "ProjectGeneralInfo"."Id" = "ProjectTimelines"."Id"
    JOIN "ProjectTeam" ON "ProjectGeneralInfo"."Id" = "ProjectTeam"."Id";

CREATE VIEW "GeneralInfoView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage", COALESCE("Activity", '') AS "Activity", COALESCE("Program", '') AS "Program", COALESCE("RGT", '') AS "RGT", COALESCE("Description", '') AS "Description",
    COALESCE("BusinessGoals", '') AS "BusinessGoals"
    FROM "ProjectGeneralInfo" JOIN "ProjectGoals" ON "ProjectGeneralInfo"."Id" = "ProjectGoals"."Id"; 

CREATE VIEW "ConditionView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("Progress", '') AS "Progress", COALESCE("Goals", '') AS "Goals", COALESCE("Timelines", '') AS "Timelines", COALESCE("Budget", '') AS "Budget", COALESCE("Contents", '') AS "Contents", COALESCE("ReportLink", '') AS "ReportLink"
    FROM "ProjectGeneralInfo" JOIN "ProjectCondition" ON "ProjectGeneralInfo"."Id" = "ProjectCondition"."Id"; 

CREATE VIEW "TeamView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("Customer", '') AS "Customer", COALESCE("Manager", '') AS "Manager", COALESCE("TeamLead", '') AS "TeamLead", COALESCE("BusinessAnalyst", '') AS "BusinessAnalyst", COALESCE("MCPeople", '') AS "MCPeople"
    FROM "ProjectGeneralInfo" JOIN "ProjectTeam" ON "ProjectGeneralInfo"."Id" = "ProjectTeam"."Id"; 

CREATE VIEW "TimelinesView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("ActualStart", '') AS "ActualStart", COALESCE("ActualEnd", '') AS "ActualEnd", COALESCE("ActualDuration", '') AS "ActualDuration", COALESCE("BaseEnd", '') AS "BaseEnd", COALESCE("BaseDeviation", '') AS "BaseDeviation", COALESCE("PassportStartYear", '') AS "PassportStartYear", COALESCE("PassportEndYear", '') AS "PassportEndYear"
    FROM "ProjectGeneralInfo" JOIN "ProjectTimelines" ON "ProjectGeneralInfo"."Id" = "ProjectTimelines"."Id"; 

CREATE VIEW "CostView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("Profitability", '') AS "Profitability", COALESCE("BaseCAPEXExt", '') AS "BaseCAPEXExt", COALESCE("BaseCAPEXWF", '') AS "BaseCAPEXWF", COALESCE("BaseOPEX", '') AS "BaseOPEX", COALESCE("PassportCAPEXExt", '') AS "PassportCAPEXExt", COALESCE("PassportCAPEXWF", '') AS "PassportCAPEXWF", COALESCE("PassportOPEX", '') AS "PassportOPEX", COALESCE("ActualCAPEXExt", '') AS "ActualCAPEXExt", COALESCE("ActualCAPEXWF", '') AS "ActualCAPEXWF", COALESCE("ActualOPEX", '') AS "ActualOPEX"
    FROM "ProjectGeneralInfo" JOIN "ProjectCost" ON "ProjectGeneralInfo"."Id" = "ProjectCost"."Id"; 

CREATE VIEW "DocumentsView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("ImplStartDecision", '') AS "ImplStartDecision", COALESCE("Timelines", '') AS "Timelines", COALESCE("Budget", '') AS "Budget", COALESCE("Contents", '') AS "Contents", COALESCE("StopResumeDecision", '') AS "StopResumeDecision", COALESCE("CloseCompleteDecision", '') AS "CloseCompleteDecision"
    FROM "ProjectGeneralInfo" JOIN "ProjectDocuments" ON "ProjectGeneralInfo"."Id" = "ProjectDocuments"."Id"; 

CREATE VIEW "GoalsView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("Product", '') AS "Product", COALESCE("ImplCriteria", '') AS "ImplCriteria", COALESCE("GoalsStatus", '') AS "GoalsStatus", COALESCE("BusinessGoals", '') AS "BusinessGoals", COALESCE("AchieveCriteria", '') AS "AchieveCriteria", COALESCE("BusinessGoalsStatus", '') AS "BusinessGoalsStatus"
    FROM "ProjectGeneralInfo" JOIN "ProjectGoals" ON "ProjectGeneralInfo"."Id" = "ProjectGoals"."Id";

CREATE VIEW "MonitoringView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage",
    COALESCE("Sign", '') AS "Sign", COALESCE("MonitoringStatus", '') AS "MonitoringStatus", COALESCE("EndYear", '') AS "EndYear", COALESCE("Product", '') AS "Product", COALESCE("Manager", '') AS "Manager", COALESCE("Characteristics", '') AS "Characteristics", COALESCE("ShortName", '') AS "ShortName"
    FROM "ProjectGeneralInfo" JOIN "ProjectMonitoring" ON "ProjectGeneralInfo"."Id" = "ProjectMonitoring"."Id";

CREATE VIEW "NotDisplayedView" AS
    SELECT "ProjectGeneralInfo"."Id",
    COALESCE("Year", '') AS "Year", COALESCE("Status", '') AS "Status", COALESCE("Code", '') AS "Code", COALESCE("Name", '') AS "Name", COALESCE("Stage", '') AS "Stage", COALESCE("Priority", '') AS "Priority", COALESCE("PostMonitoring", '') AS "PostMonitoring", COALESCE("Category", '') AS "Category", COALESCE("StrategyBelonging", '') AS "StrategyBelonging", COALESCE("RGT", '') AS "RGT", COALESCE("Dependencies", '') AS "Dependencies",
    COALESCE("GeneralStatus", '') AS "GeneralStatus",
    COALESCE("ProductOwner", '') AS "ProductOwner", COALESCE("Stakeholders", '') AS "Stakeholders", COALESCE("ExternalPeople", '') AS "ExternalPeople", COALESCE("ADM", '') AS "ADM", COALESCE("FRC", '') AS "FRC", COALESCE("BusinessLines", '') AS "BusinessLines",
    COALESCE("PreStart", '') AS "PreStart", COALESCE("PreEndActual", '') AS "PreEndActual", COALESCE("PreDuration", '') AS "PreDuration", COALESCE("PreEndPlanned", '') AS "PreEndPlanned", COALESCE("PreDeviation", '') AS "PreDeviation", COALESCE("BaseStart", '') AS "BaseStart", COALESCE("PassportEnd", '') AS "PassportEnd", COALESCE("PassportDeviation", '') AS "PassportDeviation",
    COALESCE("PreCAPEXExt", '') AS "PreCAPEXExt", COALESCE("PreCAPEXWF", '') AS "PreCAPEXWF", COALESCE("PreOPEX", '') AS "PreOPEX", COALESCE("PreCAPEXExtActual", '') AS "PreCAPEXExtActual", COALESCE("PreCAPEXExtDeltaPercent", '') AS "PreCAPEXExtDeltaPercent", COALESCE("PassportCAPEXExtDelta", '') AS "PassportCAPEXExtDelta", COALESCE("PassportCAPEXExtDeltaPercent", '') AS "PassportCAPEXExtDeltaPercent", COALESCE("ActualCAPEXExtDelta", '') AS "ActualCAPEXExtDelta", COALESCE("ActualCAPEXExtDeltaPercent", '') AS "ActualCAPEXExtDeltaPercent",
    COALESCE("PrePStartDecision", '') AS "PrePStartDecision", COALESCE("ReasonCRTimelines", '') AS "ReasonCRTimelines", COALESCE("ReasonCRBudget", '') AS "ReasonCRBudget", COALESCE("ReasonCRContents", '') AS "ReasonCRContents", COALESCE("StopReason", '') AS "StopReason", COALESCE("CloseReason", '') AS "CloseReason"
    FROM "ProjectGeneralInfo"
    JOIN "ProjectCondition" ON "ProjectGeneralInfo"."Id" = "ProjectCondition"."Id"
    JOIN "ProjectTeam" ON "ProjectGeneralInfo"."Id" = "ProjectTeam"."Id"
    JOIN "ProjectTimelines" ON "ProjectGeneralInfo"."Id" = "ProjectTimelines"."Id"
    JOIN "ProjectCost" ON "ProjectGeneralInfo"."Id" = "ProjectCost"."Id"
    JOIN "ProjectDocuments" ON "ProjectGeneralInfo"."Id" = "ProjectDocuments"."Id"
