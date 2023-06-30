CREATE PROCEDURE [dbo].[AddStudent]
	@firstname VARCHAR(50),
	@lastname VARCHAR(50),
	@birthDate DATETIME2(7),
	@yearResult INT,
	@sectionId INT
AS
BEGIN
	INSERT INTO Student (FirstName, LastName, SectionID, YearResult, BirthDate)
	VALUES (@firstname, @lastname, @sectionId, @yearResult, @birthDate)
END