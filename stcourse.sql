CREATE TABLE [dbo].[STCourses] (
    [Id]     INT           Identity,
    [Title]  VARCHAR (30)  NULL,
    [Fee]    INT           NOT NULL,
    [Prereq] VARCHAR (100) NULL,
    CONSTRAINT [PK_dbo.Courses] PRIMARY KEY CLUSTERED ([Id] ASC)
);


insert into stcourses values('Java SE',4000,'C Langauge')
insert into stcourses values('Java EE',5000,'Java SE and SQL')
insert into stcourses values('ASP.NET MVC',4000,'C#')
