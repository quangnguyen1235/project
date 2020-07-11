CREATE DATABASE DBLab3
USE DBlab3
CREATE TABLE Customer(
	cID			INT				NOT NULL			PRIMARY KEY IDENTITY(1,1),
	cName		VARCHAR(20)		NOT NULL,
	cAge		INT				NOT NULL,
	cGender		BIT				NOT NULL			DEFAULT(1),
);
CREATE TABLE Product(
	pID			INT				NOT NULL			PRIMARY KEY IDENTITY(1,1),
	pName		VARCHAR(20)		NOT NULL,
	pPrice		INT				NOT NULL,
);
CREATE TABLE Oder(
	oID			INT				NOT NULL			PRIMARY KEY	IDENTITY(1,1),
	cID			INT				NOT NULL			FOREIGN KEY REFERENCES Customer(cID),
	oDate		DATE			NOT NULL,
);
CREATE TABLE OderDetail(
	oID			INT				NOT NULL			FOREIGN KEY REFERENCES Oder(oID),
	pID			INT				NOT NULL			FOREIGN KEY REFERENCES Product(pID),
	oQTY		INT				NOT NULL,
);
INSERT INTO Customer(cName,cAge,cGender) VALUES
	('Nguyen Dang Quang', 22, 1),
	('Nguyen Xuan Trung', 33, 1),
	('Le Thi Kim Tram', 20,	0),
	('Nguyen Thi Ghi', 26, 0),
	('Ton That Anh Minh',20, 1)
;
INSERT INTO	Product(pName, pPrice) VALUES
	('Dac Nhan Tam', 150000),
	('Lam Chu Cuoc Song', 75000),
	('Toi Tai Gioi', 20000)
;
INSERT INTO Oder(cID, oDate) VALUES
	(1,'3/21/2020'),
	(2,'3/23/2020'),
	(1,'3/16/2020')
;
INSERT INTO OderDetail(oID,pID,oQTY) VALUES
	(1,4,3),
	(1,5,7),
	(2,6,1),
	(3,4,8),
	(2,5,3)
;