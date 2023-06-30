CREATE TABLE [dbo].[Student]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	BirthDate DATETIME2(7) NOT NULL,
	YearResult INT NOT NULL,
	SectionID INT NOT NULL,
	Active BIT DEFAULT 1, 
    CONSTRAINT [FK_Student_Section] FOREIGN KEY ([SectionID]) REFERENCES [Section]([ID]), 
    CONSTRAINT [CK_Student_YearResult] CHECK (YearResult BETWEEN 0 AND 20), 
    CONSTRAINT [CK_Student_BirthDate] CHECK (BirthDate > '1930-01-01')

)

GO

CREATE TRIGGER [dbo].[OnDeleteStudent]
    ON [dbo].[Student]
    INSTEAD OF DELETE
    AS
    BEGIN
        UPDATE Student SET Active = 0
        WHERE ID = (SELECT ID FROM deleted)
    END