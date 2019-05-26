CREATE VIEW CompleteCheckView AS
SELECT 
	p.ProductName, 
	p.ProductNo, 
	lc.LabelNo, 
	tc.LidNo, 
	po.ProcessOrderNo, 
	po.BatchCode, 
	tc.PreformNo, 
	sc.PalletNo 
FROM ProcessOrder AS po 
INNER JOIN Product AS p ON po.ProductNo = p.ProductNo 
INNER JOIN LabelCheck AS lc ON lc.ProcessOrderNo=po.ProcessOrderNo
INNER JOIN TorqueCheck AS tc ON tc.ProcessOrderNo=po.ProcessOrderNo
INNER JOIN ShiftCheck AS sc ON sc.ProcessOrderNo=po.ProcessOrderNo