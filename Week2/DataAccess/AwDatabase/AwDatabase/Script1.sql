SELECT 
count(c.CustomerId) as [Number Of Customers],
a.CountryRegion as [Country]

FROM SalesLT.Customer c
JOIN 
	[SalesLT].[CustomerAddress] ca
ON ca.CustomerID = c.CustomerID
JOIN
	[SalesLT].[Address] a
ON a.AddressID = ca.AddressID
Group by a.CountryRegion
Having count(c.CustomerId)  > 100


