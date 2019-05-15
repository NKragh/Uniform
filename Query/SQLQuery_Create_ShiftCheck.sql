CREATE TABLE ShiftCheck(
	ProcessOrderNo INT NOT NULL FOREIGN KEY REFERENCES ProcessOrder(ProcessOrderNo),
	CheckTime TIME NOT NULL DEFAULT (CONVERT (time, GETDATE())),
	TopLabel BIT NOT NULL,
	TapPipe BIT NOT NULL, 
	Sugar BIT NOT NULL,
	PalletNo INT NOT NULL,
	EmployeeNo INT NOT NULL FOREIGN KEY REFERENCES Employee(EmployeeNo)
	PRIMARY KEY (ProcessOrderNo, CheckTime)
	);