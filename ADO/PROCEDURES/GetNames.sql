USE [AdventureWorks2019]
GO

/****** Object:  StoredProcedure [dbo].[GetNames]    Script Date: 1/7/2024 1:04:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[GetNames]

AS 
Begin


Select BusinessEntityID, CONCAT (LastName, ', ', FirstName,' ', MiddleName) as FullName
from Person.Person
Order by LastName

End
GO

