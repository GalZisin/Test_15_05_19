/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[FIRST_NAME]
      ,[LAST_NAME]
      ,[ADDRESS]
      ,[AGE]
  FROM [School].[dbo].[Students]