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

-- COPY "ProjectGeneralInfo" ("Id", "Year", "Status", "Code", "Name", "Stage", "Priority", "PostMonitoring", "Activity", "Category", "Program", "StrategyBelonging", "RGT", "Description", "Dependencies") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	23	Архив	preCOC	Game	Done	3	\N	\N	\N	\N	\N	\N	mmm good	\N
-- b7eadf4f-e161-42fe-9db6-9f906432025f	24	В портфеле	COC1	Web App	In Progress	7	\N	\N	\N	\N	\N	\N	\N	\N
-- \.

-- COPY "ProjectCondition" ("Id", "Progress", "GeneralStatus", "Goals", "Timelines", "Budget", "Contents", "ReportLink") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	50	Almost Archived	4	1	100	7	www.ya.ru
-- b7eadf4f-e161-42fe-9db6-9f906432025f	86	Paused	8	18	1000	3	www.ya.ru
-- \.

-- COPY "ProjectTeam" ("Id", "Customer", "ProductOwner", "Manager", "TeamLead", "BusinessAnalyst", "MCPeople", "Stakeholders", "ExternalPeople", "ADM", "FRC", "BusinessLines") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	customer1	mom	dad	dog	\N	\N	\N	\N	\N	\N	university
-- b7eadf4f-e161-42fe-9db6-9f906432025f	customer2	\N	me	me	me	\N	\N	\N	\N	\N	school
-- \.

-- COPY "ProjectTimelines" ("Id", "PreStart", "PreEndActual", "PreDuration", "PreEndPlanned", "PreDeviation", "ActualStart", "ActualEnd", "ActualDuration", "BaseStart", "BaseEnd", "BaseDeviation", "PassportEnd", "PassportDeviation", "PassportStartYear", "PassportEndYear") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	07.07.2022	25.06.2023	11	15.09.2022	-283	27.06.2023	02.12.2024	17	27.06.2023	02.12.2024	0	05.06.2024	-180	2023	2024
-- b7eadf4f-e161-42fe-9db6-9f906432025f	30.10.2023	20.01.2024	2	20.01.2024	0	26.02.2024	25.12.2024	9	26.02.2024	25.12.2024	0	25.12.2024	0	2024	2024
-- \.

-- COPY "ProjectCost" ("Id", "Profitability", "PreCAPEXExt", "PreCAPEXWF", "PreOPEX", "PreCAPEXExtActual", "PreCAPEXExtDeltaPercent", "BaseCAPEXExt", "BaseCAPEXWF", "BaseOPEX", "PassportCAPEXExt", "PassportCAPEXWF", "PassportOPEX", "PassportCAPEXExtDelta", "PassportCAPEXExtDeltaPercent", "ActualCAPEXExt", "ActualCAPEXWF", "ActualOPEX", "ActualCAPEXExtDelta", "ActualCAPEXExtDeltaPercent") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	да	\N	\N	\N	\N	\N	22984	4700	0.0	22984	4700	0.0	0.0	100	\N	\N	\N	\N	\N
-- b7eadf4f-e161-42fe-9db6-9f906432025f	нет	\N	\N	\N	\N	\N	4042	3161	0.0	4042	3161	0.0	0.0	100	\N	\N	\N	\N	\N
-- \.

-- COPY "ProjectDocuments" ("Id", "PrePStartDecision", "ImplStartDecision", "Timelines", "ReasonCRTimelines", "Budget", "ReasonCRBudget", "Contents", "ReasonCRContents", "StopResumeDecision", "StopReason", "CloseCompleteDecision", "CloseReason") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	\N	ПК №08 от 07.07.2022	ПК №06 от 27.06.2023г.	\N	Уточнение требований в процессе реализации проекта:	\N	Уточнение требований в процессе реализации проекта:	\N	Уточнение требований в процессе реализации проекта:	\N	\N	\N
-- b7eadf4f-e161-42fe-9db6-9f906432025f	\N	ПК №10 от 24.10.2023г.	ПК №02 от 11.03.2024г.	\N	\N	\N	\N	\N	\N	\N	\N	\N
-- \.

-- COPY "ProjectGoals" ("Id", "Product", "ImplCriteria", "GoalsStatus", "BusinessGoals", "AchieveCriteria", "BusinessGoalsStatus") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	wot	1%	started	gold	million	far
-- b7eadf4f-e161-42fe-9db6-9f906432025f	telegram	bought	thought	money	porsche	dreams
-- \.

-- COPY "ProjectMonitoring" ("Id", "Sign", "MonitoringStatus", "EndYear", "Product", "Manager", "Characteristics", "ShortName") FROM stdin;
-- 15a84b93-e3a6-4bd0-9130-e9cddfe42328	да	\N	\N	\N	\N	\N	far
-- b7eadf4f-e161-42fe-9db6-9f906432025f	нет	\N	\N	\N	\N	\N	dreams
-- \.

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
