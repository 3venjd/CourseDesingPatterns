CREATE DATABASE [DesingPatterns]

USE [DesingPatterns]

drop table Beer
CREATE TABLE Beer
(
	BeerId INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(50),
	Style VARCHAR(50),
	BrandId UNIQUEIDENTIFIER DEFAULT NEWID(),
	CONSTRAINT FK_BrandId FOREIGN KEY (BrandId)
	REFERENCES Brand(BrandId)
);

delete from Beer where BeerId = 6

drop table Brand

CREATE TABLE Brand
(
	--BrandId INT IDENTITY(1,1) PRIMARY KEY,
	BrandId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	Name VARCHAR(50),
);

delete from Beer


INSERT INTO 
	Beer (Name, Style, BrandId) 
VALUES 
	('Minerva','Stout','AB3AFF83-7573-484D-9891-E6A2A24244DF'),
	('Erginger', 'Dunkel','AB3AFF83-7573-484D-9891-E6A2A24244DF')


INSERT INTO 
	Brand(Name)
VALUES
	('Delirium')

	
SELECT *
FROM Beer

SELECT *
FROM Brand