SELECT FirstName + ' ' + LastName as [Full name], Salary
FROM Employees 
WHERE Salary >= 50000
ORDER BY Salary DESC