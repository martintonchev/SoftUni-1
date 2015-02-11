SELECT FirstName + ' ' + LastName as [Full name], Salary
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)