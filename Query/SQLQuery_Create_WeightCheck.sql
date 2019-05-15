CREATE TABLE WeightCheck(
	ProcessOrderNo INT NOT NULL FOREIGN KEY REFERENCES ProcessOrder(ProcessOrderNo),
	CheckTime TIME NOT NULL DEFAULT (CONVERT (time, GETDATE())),
	Weight1 FLOAT NOT NULL,
	Weight2 FLOAT NOT NULL,
	Weight3 FLOAT NOT NULL,
	Weight4 FLOAT NOT NULL,
	Weight5 FLOAT NOT NULL,
	Weight6 FLOAT NOT NULL,
	Droptest BIT NOT NULL,
	Comment NVARCHAR(140) NOT NULL,
	EmployeeNo INT FOREIGN KEY REFERENCES Employee(EmployeeNo),
	ProductNo INT FOREIGN KEY REFERENCES Product(ProductNo),
	PRIMARY KEY (ProcessOrderNo, CheckTime)
	);