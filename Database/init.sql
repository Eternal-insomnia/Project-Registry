CREATE TABLE "ProjectsGeneralInfo" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Year" text NOT NULL,
    "Status" text NOT NULL,
    "Code" text NOT NULL,
    "Name" text NOT NULL,
    "Stage" text NOT NULL,
    "Priority" real,
    "Monitoring" text,
    "Activity" text,
    "Category" text,
    "Program" text,
    "StrategyBelonging" text,
    "RGT" character(1),
    "Description" text
);

CREATE TABLE "ProjectsCondition" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Progress" int,
    "Status" text,
    "Goals" int,
    "Deadlines" int,
    "Budget" int,
    "Contents" int,
    "ReportLink" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectsTeam" (
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
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectsTimelines" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "PreStart" date,
    "PreEndActual" date,
    "PreDuration" int,
    "PreEndPlanned" date,
    "PreDeviation" int,
    "ActualStart" date,
    "ActualEnd" date,
    "ActualDuration" int,
    "BaseStart" date,
    "BaseEnd" date,
    "BaseDeviation" int,
    "PassportEnd" date,
    "PassportDeviation" int,
    "PassportStartYear" int,
    "PassportEndYear" int,
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectsCost" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Profitability" text,
    "PreCAPEXExt" real,
    "PreCAPEXWF" real,
    "PreOPEX" real,
    "PreCAPEXExtActual" real,
    "PreCAPEXExtDeltaPercent" real,
    "BaseCAPEXExt" real,
    "BaseCAPEXWF" real,
    "BaseOPEX" real,
    "PassportCAPEXExt" real,
    "PassportCAPEXWF" real,
    "PassportOPEX" real,
    "PassportCAPEXExtDelta" real,
    "PassportCAPEXExtDeltaPercent" real,
    "ActualCAPEXExt" real,
    "ActualCAPEXWF" real,
    "ActualOPEX" real,
    "ActualCAPEXExtDelta" real,
    "ActualCAPEXExtDeltaPercent" real,
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);

CREATE TABLE "ProjectsDocuments" (
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
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);


CREATE TABLE "ProjectsGoals" (
    "Id" uuid NOT NULL UNIQUE PRIMARY KEY,
    "Product" text,
    "ImplCriteria" text,
    "GoalsStatus" text,
    "BusinessGoals" text,
    "AchieveCriteria" text,
    "BusinessGoalsStatus" text,
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);

COPY "ProjectsGeneralInfo" ("Id", "Year", "Status", "Code", "Name", "Stage", "Priority", "Monitoring", "Activity", "Category", "Program", "StrategyBelonging", "RGT", "Description") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	23	Archived	preCOC	Game	Done	3	\N	\N	\N	\N	\N	\N	mmm good
b7eadf4f-e161-42fe-9db6-9f906432025f	24	Archived	COC1	Web App	In Progress	7	\N	\N	\N	\N	\N	\N	\N
\.

COPY "ProjectsCondition" ("Id", "Progress", "Status", "Goals", "Deadlines", "Budget", "Contents", "ReportLink") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	50	Almost Archived	4	1	100	7	www.ya.ru
b7eadf4f-e161-42fe-9db6-9f906432025f	86	Paused	8	18	1000	3	www.ya.ru
\.

COPY "ProjectsTeam" ("Id", "Customer", "ProductOwner", "Manager", "TeamLead", "BusinessAnalyst", "MCPeople", "Stakeholders", "ExternalPeople", "ADM", "FRC", "BusinessLines") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	customer1	mom	dad	dog	\N	\N	\N	\N	\N	\N	university
b7eadf4f-e161-42fe-9db6-9f906432025f	customer2	\N	me	me	me	\N	\N	\N	\N	\N	school
\.

COPY "ProjectsTimelines" ("Id", "PreStart", "PreEndActual", "PreDuration", "PreEndPlanned", "PreDeviation", "ActualStart", "ActualEnd", "ActualDuration", "BaseStart", "BaseEnd", "BaseDeviation", "PassportEnd", "PassportDeviation", "PassportStartYear", "PassportEndYear") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	07.07.2022	25.06.2023	11	15.09.2022	-283	27.06.2023	02.12.2024	17	27.06.2023	02.12.2024	0	05.06.2024	-180	2023	2024
b7eadf4f-e161-42fe-9db6-9f906432025f	30.10.2023	20.01.2024	2	20.01.2024	0	26.02.2024	25.12.2024	9	26.02.2024	25.12.2024	0	25.12.2024	0	2024	2024
\.

COPY "ProjectsCost" ("Id", "Profitability", "PreCAPEXExt", "PreCAPEXWF", "PreOPEX", "PreCAPEXExtActual", "PreCAPEXExtDeltaPercent", "BaseCAPEXExt", "BaseCAPEXWF", "BaseOPEX", "PassportCAPEXExt", "PassportCAPEXWF", "PassportOPEX", "PassportCAPEXExtDelta", "PassportCAPEXExtDeltaPercent", "ActualCAPEXExt", "ActualCAPEXWF", "ActualOPEX", "ActualCAPEXExtDelta", "ActualCAPEXExtDeltaPercent") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	да	\N	\N	\N	\N	\N	22984	4700	0.0	22984	4700	0.0	0.0	100	\N	\N	\N	\N	\N
b7eadf4f-e161-42fe-9db6-9f906432025f	нет	\N	\N	\N	\N	\N	4042	3161	0.0	4042	3161	0.0	0.0	100	\N	\N	\N	\N	\N
\.

COPY "ProjectsDocuments" ("Id", "PrePStartDecision", "ImplStartDecision", "Timelines", "ReasonCRTimelines", "Budget", "ReasonCRBudget", "Contents", "ReasonCRContents", "StopResumeDecision", "StopReason", "CloseCompleteDecision", "CloseReason") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	\N	ПК №08 от 07.07.2022	ПК №06 от 27.06.2023г.	\N	Уточнение требований в процессе реализации проекта:	\N	Уточнение требований в процессе реализации проекта:	\N	Уточнение требований в процессе реализации проекта:	\N	\N	\N
b7eadf4f-e161-42fe-9db6-9f906432025f	\N	ПК №10 от 24.10.2023г.	ПК №02 от 11.03.2024г.	\N	\N	\N	\N	\N	\N	\N	\N	\N
\.

COPY "ProjectsGoals" ("Id", "Product", "ImplCriteria", "GoalsStatus", "BusinessGoals", "AchieveCriteria", "BusinessGoalsStatus") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	wot	1%	started	gold	million	far
b7eadf4f-e161-42fe-9db6-9f906432025f	telegram	bought	thought	money	porsche	dreams
\.

CREATE VIEW "ProjectsConditionView" AS
    SELECT "Code", "Name", "Stage", "Progress", "Goals", "Deadlines", "Budget", "Contents", "ReportLink"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsCondition" ON "ProjectsGeneralInfo"."Id" = "ProjectsCondition"."Id"; 

CREATE VIEW "ProjectsTeamView" AS
    SELECT "Code", "Name", "Stage", "Customer", "Manager", "TeamLead", "BusinessAnalyst", "MCPeople"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsTeam" ON "ProjectsGeneralInfo"."Id" = "ProjectsTeam"."Id"; 

CREATE VIEW "ProjectsTimelinesView" AS
    SELECT "Code", "Name", "Stage", "ActualStart", "ActualEnd", "ActualDuration", "BaseEnd", "BaseDeviation", "PassportStartYear", "PassportEndYear"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsTimelines" ON "ProjectsGeneralInfo"."Id" = "ProjectsTimelines"."Id"; 

CREATE VIEW "ProjectsCostView" AS
    SELECT "Code", "Name", "Stage", "Profitability", "BaseCAPEXExt", "BaseCAPEXWF", "BaseOPEX", "PassportCAPEXExt", "PassportCAPEXWF", "PassportOPEX", "ActualCAPEXExt", "ActualCAPEXWF", "ActualOPEX"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsCost" ON "ProjectsGeneralInfo"."Id" = "ProjectsCost"."Id"; 

CREATE VIEW "ProjectsDocumentsView" AS
    SELECT "Code", "Name", "Stage", "ImplStartDecision", "Timelines", "Budget", "Contents", "StopResumeDecision", "CloseCompleteDecision"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsDocuments" ON "ProjectsGeneralInfo"."Id" = "ProjectsDocuments"."Id"; 

CREATE VIEW "ProjectsGoalsView" AS
    SELECT "Code", "Name", "Stage", "Product", "ImplCriteria", "GoalsStatus", "BusinessGoals", "AchieveCriteria", "BusinessGoalsStatus"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsGoals" ON "ProjectsGeneralInfo"."Id" = "ProjectsGoals"."Id";
