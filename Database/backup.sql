CREATE TABLE "ProjectsGeneralInfo" (
    "Id" uuid NOT NULL PRIMARY KEY,
    "Year" text NOT NULL,
    "Status" text NOT NULL,
    "Code" text NOT NULL,
    "Name" text NOT NULL,
    "Stage" text NOT NULL,
    "Priority" real NOT NULL,
    "Monitoring" text,
    "Activity" text,
    "Category" text,
    "Program" text,
    "StrategyBelonging" text,
    "RGT" character(1)
);

CREATE TABLE "ProjectsCondition" (
    "Id" uuid NOT NULL PRIMARY KEY,
    "Progress" int NOT NULL,
    "Status" text,
    "Goals" int NOT NULL,
    "Deadlines" int NOT NULL,
    "Budget" int NOT NULL,
    "Content" int NOT NULL,
    "ReportLink" text NOT NULL,
    FOREIGN KEY ("Id") REFERENCES "ProjectsGeneralInfo"("Id") ON DELETE CASCADE
);

COPY "ProjectsGeneralInfo" ("Id", "Year", "Status", "Code", "Name", "Stage", "Priority", "Monitoring", "Activity", "Category", "Program", "StrategyBelonging", "RGT") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	23	Archived	preCOC	Game	Done	3	\N	\N	\N	\N	\N	\N
b7eadf4f-e161-42fe-9db6-9f906432025f	24	Archived	COC1	Web App	In Progress	7	\N	\N	\N	\N	\N	\N
\.

COPY "ProjectsCondition" ("Id", "Progress", "Status", "Goals", "Deadlines", "Budget", "Content", "ReportLink") FROM stdin;
15a84b93-e3a6-4bd0-9130-e9cddfe42328	50	Almost Archived	4	1	100	7	www.ya.ru
b7eadf4f-e161-42fe-9db6-9f906432025f	86	Paused	8	18	1000	3	www.ya.ru
\.

CREATE VIEW "ProjectConditionView" AS
    SELECT "Code", "Name", "Stage", "Progress", "Goals", "Deadlines", "Budget", "Content", "ReportLink"
    FROM "ProjectsGeneralInfo" JOIN "ProjectsCondition" ON "ProjectsGeneralInfo"."Id" = "ProjectsCondition"."Id"; 
