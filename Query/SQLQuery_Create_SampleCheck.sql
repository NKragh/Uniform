CREATE TABLE SampleCheck(
	ProcessOrderNo INT NOT NULL FOREIGN KEY REFERENCES ProcessOrder(ProcessOrderNo),
	CheckTime TIME NOT NULL DEFAULT (CONVERT (time, GETDATE())),
	Sample BIT NOT NULL,
	EmployeeNo INT NOT NULL FOREIGN KEY REFERENCES Employee(EmployeeNo)
	PRIMARY KEY (ProcessOrderNo, CheckTime)
	);