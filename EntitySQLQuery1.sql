CREATE DATABASE TestEntity
GO

USE TestEntity
GO

CREATE TABLE Lop(
	ID INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) DEFAULT N'Kteam class',
)

CREATE TABLE SinhVien(
	ID INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) DEFAULT N'Kter name',
	IDLop INT NOT NULL,
	FOREIGN KEY (IDLop) REFERENCES Lop(ID)
)
GO

INSERT INTO Lop(Name) VALUES
(N'Kteam class 1'),
(N'Kteam class 2'),
(N'Kteam class 3'),
(N'Kteam class 4')

INSERT INTO SinhVien(Name, IDLop) VALUES
(N'Kter 1', 1),
(N'Kter 2', 1),
(N'Kter 3', 1),
(N'Kter 4', 1),
(N'Kter 1', 2),
(N'Kter 2', 2),
(N'Kter 3', 2),
(N'Kter 4', 2),
(N'Kter 1', 3),
(N'Kter 2', 3),
(N'Kter 3', 3),
(N'Kter 4', 3),
(N'Kter 1', 4),
(N'Kter 2', 4),
(N'Kter 3', 4),
(N'Kter 4', 4)

SELECT * FROM SinhVien;

DELETE FROM SinhVien
WHERE ID = 18;

TRUNCATE TABLE Lop
TRUNCATE TABLE SinhVien