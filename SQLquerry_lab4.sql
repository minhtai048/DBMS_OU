CREATE TABLE User_Plant (
    Plant_ID nvarchar(50) NOT NULL,
    User_ID nvarchar(50) NOT NULL,
    PRIMARY KEY (Plant_ID, User_ID)
);

CREATE TABLE Admin_System (
    Admin_ID nvarchar(50) NOT NULL,
	FullName nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
	DateOfBirth nvarchar(50) NOT NULL,
    PRIMARY KEY (Admin_ID)
);

CREATE TABLE User_System (
    National_ID nvarchar(50) NOT NULL,
	User_ID nvarchar(50) NOT NULL,
	Admin_ID nvarchar(50 )NOT NULL,
	FullName nvarchar(50) NOT NULL,
	DateOfBirth nvarchar(50) NOT NULL,
	Address nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
    PRIMARY KEY (User_ID)
);

CREATE TABLE Plant (
    Plant_ID nvarchar(50) NOT NULL,
	Admin_ID nvarchar(50) NOT NULL,
	Plant_Name nvarchar(50) NOT NULL,
	Temperature nvarchar(50) NOT NULL,
	Water_Level nvarchar(50) NOT NULL,
	Fertilizer_Level nvarchar(50) NOT NULL,
	Condition nvarchar(50) NOT NULL,
    PRIMARY KEY (Plant_ID)
);
ALTER TABLE User_Plant
ADD CONSTRAINT FK_User_Plant_Plant
FOREIGN KEY (Plant_ID)
REFERENCES Plant(Plant_ID);


ALTER TABLE User_Plant
ADD CONSTRAINT FK_User_Plant_User_System
FOREIGN KEY (User_ID)
REFERENCES User_System(User_ID);


ALTER TABLE User_System
ADD CONSTRAINT FK_User_System_Admin_System
FOREIGN KEY (Admin_ID)
REFERENCES Admin_System(Admin_ID);

ALTER TABLE Plant
ADD CONSTRAINT FK_Plant_Admin_System
FOREIGN KEY (Admin_ID)
REFERENCES Admin_System(Admin_ID);


