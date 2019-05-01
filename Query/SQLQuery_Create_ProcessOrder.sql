CREATE TABLE ProcessOrder(
	ProcessOrderNo INT NOT NULL PRIMARY KEY,
	DateTime DATETIME NOT NULL DEFAULT(getdate()),
	ProductNo INT FOREIGN KEY REFERENCES Product(ProductNo),
	EmployeeNo INT FOREIGN KEY REFERENCES Employee(EmployeeNo),
	BatchCode VARCHAR FOREIGN KEY REFERENCES Batch(BatchCode) 
	);