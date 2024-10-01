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

CREATE VIEW "ProjectsGoalsView" AS
    SELECT "Code", "Name", "Stage", "Product", "ImplCriteria", "GoalsStatus", "BusinessGoals", "AchieveCriteria", "BusinessGoalsStatus"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsGoals" ON "ProjectsGeneralInfo"."Id" = "ProjectsGoals"."Id"; 
