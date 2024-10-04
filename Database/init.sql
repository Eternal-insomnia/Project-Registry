CREATE TABLE "ProjectGeneralInfo" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Year" text NOT NULL,
    "Status" text NOT NULL,
    "Code" text NOT NULL,
    "Name" text NOT NULL,
    "Stage" text NOT NULL,
    "Priority" text,
    "PostMonitoring" text,
    "Activity" text,    
    "Category" text,
    "Program" text,
    "StrategyBelonging" text,
    "RGT" character(1),
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

COPY "ProjectGeneralInfo" ("Id", "Year", "Status", "Code", "Name", "Stage", "Priority", "PostMonitoring", "Activity", "Category", "Program", "StrategyBelonging", "RGT", "Description", "Dependencies") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	23	Archived	preCOC	Game	Done	3	\N	\N	\N	\N	\N	\N	mmm good	\N
b7eadf4f-e161-42fe-9db6-9f906432025f	24	Archived	COC1	Web App	In Progress	7	\N	\N	\N	\N	\N	\N	\N	\N
\.

COPY "ProjectCondition" ("Id", "Progress", "GeneralStatus", "Goals", "Timelines", "Budget", "Contents", "ReportLink") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	50	Almost Archived	4	1	100	7	www.ya.ru
b7eadf4f-e161-42fe-9db6-9f906432025f	86	Paused	8	18	1000	3	www.ya.ru
\.

COPY "ProjectTeam" ("Id", "Customer", "ProductOwner", "Manager", "TeamLead", "BusinessAnalyst", "MCPeople", "Stakeholders", "ExternalPeople", "ADM", "FRC", "BusinessLines") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	customer1	mom	dad	dog	\N	\N	\N	\N	\N	\N	university
b7eadf4f-e161-42fe-9db6-9f906432025f	customer2	\N	me	me	me	\N	\N	\N	\N	\N	school
\.

COPY "ProjectTimelines" ("Id", "PreStart", "PreEndActual", "PreDuration", "PreEndPlanned", "PreDeviation", "ActualStart", "ActualEnd", "ActualDuration", "BaseStart", "BaseEnd", "BaseDeviation", "PassportEnd", "PassportDeviation", "PassportStartYear", "PassportEndYear") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	07.07.2022	25.06.2023	11	15.09.2022	-283	27.06.2023	02.12.2024	17	27.06.2023	02.12.2024	0	05.06.2024	-180	2023	2024
b7eadf4f-e161-42fe-9db6-9f906432025f	30.10.2023	20.01.2024	2	20.01.2024	0	26.02.2024	25.12.2024	9	26.02.2024	25.12.2024	0	25.12.2024	0	2024	2024
\.

COPY "ProjectCost" ("Id", "Profitability", "PreCAPEXExt", "PreCAPEXWF", "PreOPEX", "PreCAPEXExtActual", "PreCAPEXExtDeltaPercent", "BaseCAPEXExt", "BaseCAPEXWF", "BaseOPEX", "PassportCAPEXExt", "PassportCAPEXWF", "PassportOPEX", "PassportCAPEXExtDelta", "PassportCAPEXExtDeltaPercent", "ActualCAPEXExt", "ActualCAPEXWF", "ActualOPEX", "ActualCAPEXExtDelta", "ActualCAPEXExtDeltaPercent") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	да	\N	\N	\N	\N	\N	22984	4700	0.0	22984	4700	0.0	0.0	100	\N	\N	\N	\N	\N
b7eadf4f-e161-42fe-9db6-9f906432025f	нет	\N	\N	\N	\N	\N	4042	3161	0.0	4042	3161	0.0	0.0	100	\N	\N	\N	\N	\N
\.

COPY "ProjectDocuments" ("Id", "PrePStartDecision", "ImplStartDecision", "Timelines", "ReasonCRTimelines", "Budget", "ReasonCRBudget", "Contents", "ReasonCRContents", "StopResumeDecision", "StopReason", "CloseCompleteDecision", "CloseReason") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	\N	ПК №08 от 07.07.2022	ПК №06 от 27.06.2023г.	\N	Уточнение требований в процессе реализации проекта:	\N	Уточнение требований в процессе реализации проекта:	\N	Уточнение требований в процессе реализации проекта:	\N	\N	\N
b7eadf4f-e161-42fe-9db6-9f906432025f	\N	ПК №10 от 24.10.2023г.	ПК №02 от 11.03.2024г.	\N	\N	\N	\N	\N	\N	\N	\N	\N
\.

COPY "ProjectGoals" ("Id", "Product", "ImplCriteria", "GoalsStatus", "BusinessGoals", "AchieveCriteria", "BusinessGoalsStatus") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	wot	1%	started	gold	million	far
b7eadf4f-e161-42fe-9db6-9f906432025f	telegram	bought	thought	money	porsche	dreams
\.

COPY "ProjectMonitoring" ("Id", "Sign", "MonitoringStatus", "EndYear", "Product", "Manager", "Characteristics", "ShortName") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	да	\N	\N	\N	\N	\N	far
b7eadf4f-e161-42fe-9db6-9f906432025f	нет	\N	\N	\N	\N	\N	dreams
\.

CREATE VIEW "HomeView" AS
    SELECT "Code", "Name", "Stage", "Priority", "Progress", "GeneralStatus", "ActualEnd", "Manager", "Description"
    FROM "ProjectGeneralInfo"
    JOIN "ProjectCondition" ON "ProjectGeneralInfo"."Id" = "ProjectCondition"."Id"
    JOIN "ProjectTimelines" ON "ProjectGeneralInfo"."Id" = "ProjectTimelines"."Id"
    JOIN "ProjectTeam" ON "ProjectGeneralInfo"."Id" = "ProjectTeam"."Id";

CREATE VIEW "ProjectGeneralInfoView" AS
    SELECT "Code", "Name", "Stage", "Activity", "Program", "RGT", "Description", "BusinessGoals"
    FROM "ProjectGeneralInfo" JOIN "ProjectGoals" ON "ProjectGeneralInfo"."Id" = "ProjectGoals"."Id"; 

CREATE VIEW "ProjectConditionView" AS
    SELECT "Code", "Name", "Stage", "Progress", "Goals", "Timelines", "Budget", "Contents", "ReportLink"
    FROM "ProjectGeneralInfo" JOIN "ProjectCondition" ON "ProjectGeneralInfo"."Id" = "ProjectCondition"."Id"; 

CREATE VIEW "ProjectTeamView" AS
    SELECT "Code", "Name", "Stage", "Customer", "Manager", "TeamLead", "BusinessAnalyst", "MCPeople"
    FROM "ProjectGeneralInfo" JOIN "ProjectTeam" ON "ProjectGeneralInfo"."Id" = "ProjectTeam"."Id"; 

CREATE VIEW "ProjectTimelinesView" AS
    SELECT "Code", "Name", "Stage", "ActualStart", "ActualEnd", "ActualDuration", "BaseEnd", "BaseDeviation", "PassportStartYear", "PassportEndYear"
    FROM "ProjectGeneralInfo" JOIN "ProjectTimelines" ON "ProjectGeneralInfo"."Id" = "ProjectTimelines"."Id"; 

CREATE VIEW "ProjectCostView" AS
    SELECT "Code", "Name", "Stage", "Profitability", "BaseCAPEXExt", "BaseCAPEXWF", "BaseOPEX", "PassportCAPEXExt", "PassportCAPEXWF", "PassportOPEX", "ActualCAPEXExt", "ActualCAPEXWF", "ActualOPEX"
    FROM "ProjectGeneralInfo" JOIN "ProjectCost" ON "ProjectGeneralInfo"."Id" = "ProjectCost"."Id"; 

CREATE VIEW "ProjectDocumentsView" AS
    SELECT "Code", "Name", "Stage", "ImplStartDecision", "Timelines", "Budget", "Contents", "StopResumeDecision", "CloseCompleteDecision"
    FROM "ProjectGeneralInfo" JOIN "ProjectDocuments" ON "ProjectGeneralInfo"."Id" = "ProjectDocuments"."Id"; 

CREATE VIEW "ProjectGoalsView" AS
    SELECT "Code", "Name", "Stage", "Product", "ImplCriteria", "GoalsStatus", "BusinessGoals", "AchieveCriteria", "BusinessGoalsStatus"
    FROM "ProjectGeneralInfo" JOIN "ProjectGoals" ON "ProjectGeneralInfo"."Id" = "ProjectGoals"."Id";

CREATE VIEW "ProjectMonitoringView" AS
    SELECT "Code", "Name", "Stage", "Sign", "MonitoringStatus", "EndYear", "Product", "Manager", "Characteristics", "ShortName"
    FROM "ProjectGeneralInfo" JOIN "ProjectMonitoring" ON "ProjectGeneralInfo"."Id" = "ProjectMonitoring"."Id";
