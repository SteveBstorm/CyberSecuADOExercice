CREATE PROCEDURE [dbo].[UpdateStudent]
	@sectionId INT,
	@yearResult INT,
	@studentId INT
AS
	UPDATE Student SET SectionID = @sectionId,
					   YearResult = @yearResult
	WHERE ID = @studentId