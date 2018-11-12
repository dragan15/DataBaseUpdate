BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Restaraunt_table` (
	`Restaraunt_ID`	INTEGER,
	`Restaraunt_Name`	TEXT,
	`Restaraunt_Address`	TEXT,
	`Restaraunt_City`	TEXT,
	`Restaraunt_State`	TEXT,
	`Restaraunt_Zip`	INTEGER,
	`Restaraunt_Phone`	TEXT,
	`Restaraunt_email`	TEXT,
	`Restaraunt_Lat`	NUMERIC,
	`Restaraunt_Long`	NUMERIC,
	`Restaraunt_Menu`	BLOB,
	PRIMARY KEY(`Restaraunt_ID`),
	FOREIGN KEY(`Restaraunt_Menu`) REFERENCES `Restaraunt_Menu`(`Menu_ID`)
);

CREATE TABLE IF NOT EXISTS `Restaraunt_Menu` (
	`Menu_ID`	INTEGER,
	`Menu_Name`	TEXT,
	`Menu_Category_ID`	BLOB,
	`Menu_Description`	TEXT,
	`Menu_Image`	BLOB,
	PRIMARY KEY(`Menu_ID`),
	FOREIGN KEY(`Menu_Category_ID`) REFERENCES `Menu_Category`(`Category_ID`)
);

CREATE TABLE IF NOT EXISTS `Menu_Category` (
	`Category_ID`	INTEGER,
	`Category_Name`	TEXT,
	`Category_Description`	TEXT,
	`Category_Price`	NUMERIC,
	PRIMARY KEY(`Category_ID`)
);

COMMIT;
