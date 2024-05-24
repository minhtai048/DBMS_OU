CREATE DATABASE DBMS_OU
USE DBMS_OU

CREATE TABLE User_Plant (
    Plant_ID int NOT NULL,
    UserID int NOT NULL,
    PRIMARY KEY (Plant_ID, UserID),
	Temperature_Curr decimal(10, 2),
	Water_Curr decimal(10, 2),
	Fertilizer_Curr decimal(10, 2),
	date_curr datetime,
);

CREATE TABLE Admin_System (
    Admin_ID int identity(1,1) NOT NULL,
	userlogin nvarchar(50) NOT NULL,
	passwordlogin nvarchar(50) NOT NULL,
	FullName nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
	DateOfBirth date NOT NULL,
    PRIMARY KEY (Admin_ID)
);

CREATE TABLE User_System (
    National_ID nvarchar(50) NOT NULL,
	UserID int identity(1,1) NOT NULL,
	userlogin nvarchar(50) NOT NULL,
	passwordlogin nvarchar(50) NOT NULL,
	Admin_ID int NOT NULL,
	FullName nvarchar(50) NOT NULL,
	DateOfBirth date NOT NULL,
	AddressUser nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
    PRIMARY KEY (UserID)
);

CREATE TABLE Plant (
    Plant_ID int identity(1,1) NOT NULL,
	Admin_ID int NOT NULL,
	Plant_Name nvarchar(50) NOT NULL,
	Temperature decimal(10, 2),
	Water_Level decimal(10, 2),
	Fertilizer_Level decimal(10, 2),
    PRIMARY KEY (Plant_ID)
);
ALTER TABLE User_Plant
ADD CONSTRAINT FK_User_Plant_Plant
FOREIGN KEY (Plant_ID)
REFERENCES Plant(Plant_ID) ON DELETE CASCADE;

SELECT * FROM Admin_System
SELECT * FROM Plant


ALTER TABLE User_Plant
ADD CONSTRAINT FK_User_Plant_User_System
FOREIGN KEY (UserID)
REFERENCES User_System(UserID);


ALTER TABLE User_System
ADD CONSTRAINT FK_User_System_Admin_System
FOREIGN KEY (Admin_ID)
REFERENCES Admin_System(Admin_ID);

ALTER TABLE Plant
ADD CONSTRAINT FK_Plant_Admin_System
FOREIGN KEY (Admin_ID)
REFERENCES Admin_System(Admin_ID);

INSERT INTO Admin_System(userlogin, passwordlogin, fullname, gender, dateofbirth)
VALUES ('testadmin', 'testadmin00', 'test admin', 'Male', '1990-02-20');

INSERT INTO User_System(National_ID, userlogin, passwordlogin, Admin_ID, 
FullName, DateOfBirth, AddressUser, Gender)
VALUES ('00001', 'testuser', 'testuser00', 1, 'test user', '1990-02-20', 'TP.HCM', 'Male');

INSERT INTO plant(plant_name, temperature, water_level, fertilizer_level, Admin_ID)
VALUES('plant1', '26.6', '2.5', '5.5', 1)