CREATE DATABASE TestEntity
GO

USE TestEntity
GO

CREATE TABLE Lop(
	ID INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) DEFAULT N'Abc class',
)

CREATE TABLE SinhVien(
	ID INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) DEFAULT N'Xyz name',
	IDLop INT NOT NULL,
	FOREIGN KEY (IDLop) REFERENCES Lop(ID)
)
GO

INSERT INTO Lop(Name) VALUES
(N'Abc class 1'),
(N'Abc class 2'),
(N'Abc class 3'),
(N'Abc class 4')

INSERT INTO SinhVien(Name, IDLop) VALUES
(N'Xyz 1', 1),
(N'Xyz 2', 1),
(N'Xyz 3', 1),
(N'Xyz 4', 1),
(N'Xyz 1', 2),
(N'Xyz 2', 2),
(N'Xyz 3', 2),
(N'Xyz 4', 2),
(N'Xyz 1', 3),
(N'Xyz 2', 3),
(N'Xyz 3', 3),
(N'Xyz 4', 3),
(N'Xyz 1', 4),
(N'Xyz 2', 4),
(N'Xyz 3', 4),
(N'Xyz 4', 4)

SELECT * FROM SinhVien;

DELETE FROM SinhVien
WHERE ID = 18;

TRUNCATE TABLE Lop
TRUNCATE TABLE SinhVien