CREATE TABLE TasteCheck(
	ProcessOrderNo INT FOREIGN KEY REFERENCES ProcessOrder(ProcessOrderNo),
	CheckTime TIME NOT NULL DEFAULT (CONVERT (time, GETDATE())),
	TankNo INT NOT NULL,
	TasteOk BIT NOT NULL,
	EmployeeNo INT FOREIGN KEY REFERENCES Employee(EmployeeNo),
	PRIMARY KEY (ProcessOrderNo, CheckTime)
	);