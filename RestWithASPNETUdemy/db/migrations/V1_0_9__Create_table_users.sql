CREATE TABLE `users` (
	`ID` INT(10) NOT NULL AUTO_INCREMENT,
	`Login` VARCHAR(120) UNIQUE NOT NULL,
	`AccessKey` VARCHAR(50) NOT NULL,
	`Name` VARCHAR(100) NOT NULL,
	`LastName` VARCHAR(100) NOT NULL,
	`Birthday` DATETIME NULL,
	`News` bool NULL,
	PRIMARY KEY (`ID`)
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB;