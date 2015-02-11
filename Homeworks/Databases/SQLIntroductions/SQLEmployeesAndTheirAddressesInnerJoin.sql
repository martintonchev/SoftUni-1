SELECT e.FirstName + ' ' + e. LastName as [Full name], a.AddressText as Adress, t.Name as Town
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID
INNER JOIN Towns t
ON a.TownID = t.TownID
