CREATE TABLE tbl_order(
	
	orderID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	cusName varchar(30) NOT NULL,
	cusAddress varchar(30),
	cusPhone varchar(30) NOT NULL,
	cusCC varchar(30) NOT NULL,
	cusZip varchar(30),
	delivary bit NOT NULL DEFAULT 0,
	total float(24)
)

CREATE TABLE tbl_size(
	
	sizeID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	sizeName varchar(30)
)

CREATE TABLE tbl_Pizza(

	pizzaID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	orderID int NOT NULL FOREIGN KEY REFERENCES tbl_order(orderID),
	sizeID int NOT NULL FOREIGN KEY REFERENCES tbl_size(sizeID),
	pepperoni bit NOT NULL,
	mushrooms bit NOT NULL,
	onions bit NOT NULL,
	sasusage bit NOT NULL,
	bacon bit NOT NULL,
	extraCheese bit NOT NULL,
	blackOlives bit NOT NULL,
	pineapple bit NOT NULL,
	spinach bit NOT NULL
)