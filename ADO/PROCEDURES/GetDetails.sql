USE [AdventureWorks2019]
GO

/****** Object:  StoredProcedure [dbo].[GetDetails]    Script Date: 1/7/2024 1:03:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetDetails]
	@ID INT
AS
Select Person.Person.BusinessEntityID, FirstName, LastName, PersonType, AddressLine1, AddressLine2, City, Person.StateProvince.Name

FROM Person.Person
INNER JOIN Person.BusinessEntityAddress ON Person.Person.BusinessEntityID = Person.BusinessEntityAddress.BusinessEntityID
INNER JOIN Person.Address ON Person.BusinessEntityAddress.AddressID = Person.Address.AddressID
INNER JOIN Person.StateProvince on Person.Address.StateProvinceID = Person.StateProvince.StateProvinceID

WHERE Person.Person.BusinessEntityID = @ID
GO

