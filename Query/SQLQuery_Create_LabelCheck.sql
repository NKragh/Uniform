CREATE TABLE Label (
	LabelNo INT PRIMARY KEY,
	ProductNo INT FOREIGN KEY REFERENCES Product(ProductNo)
	);

CREATE TABLE LabelCheck (
	ProcessOrderNo INT FOREIGN KEY REFERENCES ProcessOrder(ProcessOrderNo),
	CheckTime TIME NOT NULL DEFAULT (CONVERT (time, GETDATE())),
	ExpirationDate DATETIME NOT NULL DEFAULT (getdate()),
	Comment NVARCHAR(140) NOT NULL,
	EmployeeNo INT FOREIGN KEY REFERENCES Employee(EmployeeNo),
	LabelNo INT FOREIGN KEY REFERENCES Label(LabelNo),
	PRIMARY KEY (ProcessOrderNo, CheckTime)
	);