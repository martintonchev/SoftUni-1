SELECT e.FirstName + ' ' + e.LastName as [Full name], a.AddressText, t.Name as Town
FROM Employees e, Addresses a, Towns t
WHERE a.TownID = t.TownID