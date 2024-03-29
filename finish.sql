CREATE DATABASE PractikaPW1;
GO

USE PractikaPW1;
GO

CREATE TABLE Zhanres(
    ID_Zhanre INT PRIMARY KEY IDENTITY(1,1),
    NameZhanre VARCHAR(50) UNIQUE NOT NULL,
    DescriptionZhanre VARCHAR(200)
);
GO

CREATE TABLE Games(
    ID_Game INT PRIMARY KEY IDENTITY(1,1),
    NameGame VARCHAR(50) UNIQUE NOT NULL,
    Zhanre_ID INT NOT NULL,
    FOREIGN KEY (Zhanre_ID) REFERENCES Zhanres(ID_Zhanre)
);
GO


INSERT INTO Zhanres(NameZhanre, DescriptionZhanre)
VALUES
	('�����','��� ������������� ������ ������, ������� ������������ ������� ����� ��������'),
	('������','������ ���������� ������ �������� ��� ��� ������� � ������ ���������'),
	('�����������','������� ������� � �������� ������������ �� ������� � �������'),
	('��������','������������� �� ���� �� ������� ���������'),
	('���������������','������� ������� ��� ������������ ��������� � ������')
GO

INSERT INTO Games(NameGame, Zhanre_ID)
VALUES
	('Valorant', 2),
	('Super Mario Bros.', 3),
	('Mortal Kombat 11', 4),
	('Uncharted 4', 1),
	('Mafia 2', 5)
GO