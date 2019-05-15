﻿CREATE TABLE Supplier(
SupplierName NVARCHAR NOT NULL PRIMARY KEY
);

CREATE TABLE Preform(
PreformNo INT NOT NULL PRIMARY KEY,
Size INT NOT NULL,
Weight FLOAT NOT NULL,
MinValue FLOAT NOT NULL,
MaxValue FLOAT NOT NULL, 
SupplierName NVARCHAR FOREIGN KEY REFERENCES Supplier(SupplierName)
);

CREATE TABLE PressureCheck(
ProcessOrderNo INT FOREIGN KEY REFERENCES ProcessOrder(ProcessOrderNo),
CheckTime TIME NOT NULL DEFAULT (CONVERT (time, GETDATE())),
FormNo INT NOT NULL,
Bar INT NOT NULL,
BreakPoint VARCHAR NOT NULL,
EmployeeNo INT FOREIGN KEY REFERENCES Employee(EmployeeNo),
PreformNo INT FOREIGN KEY REFERENCES Preform(PreformNo),
PRIMARY KEY (ProcessOrderNo, CheckTime, FormNo)
);