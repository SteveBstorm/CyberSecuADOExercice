CREATE PROCEDURE [dbo].[AddSection]
	@sectionID INT,
	@sectionName VARCHAR(50)
AS
	INSERT INTO Section VALUES (@sectionID, @sectionName)