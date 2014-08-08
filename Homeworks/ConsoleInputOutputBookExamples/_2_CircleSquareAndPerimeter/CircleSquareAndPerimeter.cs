using System;

class CircleSquareAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Please enter radius: ");
        int radius = int.Parse(Console.ReadLine());
        double perimeter = Math.PI * 2 * radius;
        double area = Math.Pow(radius, 2) * Math.PI;
        Console.WriteLine("Circle with radius: {0} has area: {1:F2} and perimeter: {2:F2}", radius, area, perimeter);
    }
}

