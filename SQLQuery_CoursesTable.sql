/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[NAME]
      ,[HOURS]
      ,[AVG_GRADE]
      ,[NUM_OF_STUDENTS]
      ,[HIGHSET_GRADE]
  FROM [School].[dbo].[Courses]