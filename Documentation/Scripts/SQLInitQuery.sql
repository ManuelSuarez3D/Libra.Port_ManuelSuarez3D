USE [master]

IF EXISTS (SELECT * FROM master.dbo.sysdatabases WHERE name = 'Libra.Port')
BEGIN
    DROP DATABASE [Libra.Port]
END
GO

CREATE DATABASE [Libra.Port];
GO

USE [Libra.Port];
GO

DROP TABLE IF EXISTS [Genres]
GO
CREATE TABLE Genres (
    [GenreId] INT IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(250) NOT NULL,
);

DROP TABLE IF EXISTS [Authors]
GO
CREATE TABLE Authors (
    [AuthorId] INT IDENTITY(1,1) PRIMARY KEY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(250) NOT NULL,
);

DROP TABLE IF EXISTS [Books]
GO
CREATE TABLE Books (
    [BookId] INT IDENTITY(1,1) PRIMARY KEY,
	[GenreId] INT,
    [AuthorId] INT,
    [Description] VARCHAR(250) NOT NULL,
    [Title] VARCHAR(50) NOT NULL,
    FOREIGN KEY (GenreId) REFERENCES Genres(GenreId),
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId),
);

DROP TABLE IF EXISTS [Users]
GO
CREATE TABLE [Users] (
	[UserId] INT IDENTITY(1,1) PRIMARY KEY,
    [Username] VARCHAR(50),
    [Password] VARCHAR(50) NOT NULL,
	[IsAdmin] BIT NOT NULL,
);

GO

SET IDENTITY_INSERT Genres ON;
INSERT INTO Genres ([GenreId], [Name], [Description]) VALUES 
(1, 'Horror',
'Evokes fear through suspense,
supernatural elements, 
or psychological terror. 
Focuses on unsettling atmospheres, eerie plots, 
and the unknown to elicit a strong emotional response from the audience.'
);
SET IDENTITY_INSERT Genres OFF;

SET IDENTITY_INSERT Authors ON;
INSERT INTO Authors ([AuthorId], [FirstName], [LastName], [Description]) VALUES 
(1, 
'Horace',
'Walpole',
'Horace Walpole (1717-1797) was an English writer, art historian, 
and politician, best known for his novel "The Castle of Otranto," 
which is considered one of the earliest Gothic novels.'
);
SET IDENTITY_INSERT Authors OFF;

SET IDENTITY_INSERT Books ON;
INSERT INTO Books ([BookId], [GenreId], [AuthorId], [Description], [Title]) VALUES 
(1, 
1,
1,
'"The Castle of Otranto" tells the story of Prince Manfred, who seeks to secure his familys lineage through his son, Conrad.',
'The Castle of Otranto'
);
SET IDENTITY_INSERT Books OFF;

SET IDENTITY_INSERT Users ON;
INSERT INTO Users([UserId],[Username], [Password], [IsAdmin]) VALUES (1,'admin', 'qwe123', 1);
SET IDENTITY_INSERT Users OFF;

SET IDENTITY_INSERT Users ON;
INSERT INTO Users([UserId],[Username], [Password], [IsAdmin]) VALUES (2,'user', 'qwe123', 0);
SET IDENTITY_INSERT Users OFF;