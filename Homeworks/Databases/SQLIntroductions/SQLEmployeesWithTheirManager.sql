SELECT e.FirstName + ' ' + e.LastName as [Full name], m.FirstName + ' ' + m.LastName as [Manager name] 
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID