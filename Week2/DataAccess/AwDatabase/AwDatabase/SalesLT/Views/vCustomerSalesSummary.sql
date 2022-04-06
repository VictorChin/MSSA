CREATE VIEW [SalesLT].[vCustomerSalesSummary]
	AS
Select c.CustomerID,c.CompanyName,
sum(soh.[TotalDue]) as Total,
min(soh.[TotalDue]) as MinOrder,
max(soh.[TotalDue]) as MaxOrder,
avg(soh.[TotalDue]) as AvgOrder
From [SalesLT].[Customer] c
Join [SalesLT].[SalesOrderHeader] soh
on c.CustomerID = soh.CustomerID
Group by c.CustomerID,c.CompanyName

