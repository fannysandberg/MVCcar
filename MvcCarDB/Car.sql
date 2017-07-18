CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Brand nvarchar(30) not null,
	Doors nvarchar(30) not null,
	TopSpeed int not null,
)
