SELECT e.FirstName + ' ' + e.LastName as [Full name], m.FirstName + ' ' + m.LastName as [Manager name], a.AddressText as Address
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
			