CREATE DATABASE [DesingPatterns]

USE [DesingPatterns]


CREATE TABLE Beer
(
	BeerId INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(50),
	Style VARCHAR(50)
);

INSERT INTO 
	Beer (Name, Style) 
VALUES 
	('Minerva','Stout'),
	('Erginger', 'Dunkel')

SELECT *
FROM Beer

delete from Beer where BeerId = 6

CREATE TABLE Brand
(
	BrandId INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(50),
);

drop table Brand

SELECT *
FROM Brand