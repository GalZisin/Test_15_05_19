/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [COURSE_ID]
      ,[STUDENT_ID]
      ,[GRADE]
  FROM [School].[dbo].[Grades]