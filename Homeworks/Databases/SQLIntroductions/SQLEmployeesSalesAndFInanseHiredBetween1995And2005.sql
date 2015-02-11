SELECT e.FirstName, e.LastName, e.HireDate, d.Name
FROM Employees e, Departments d
WHERE (e.HireDate BETWEEN '2001' AND '2005') AND 
	(e.DepartmentID = d.DepartmentID) AND
	(d.Name = 'Sales' OR d.Name = 'Finance')