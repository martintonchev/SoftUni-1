using System;

class RootsOfQuadricEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter coefficient \"a\" of a quadric equation: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient \"b\" of a quadric equation: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient \"c\" of a quadric equation: ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("There is no real square roots");
        }
        else if (discriminant == 0)
        {
            double x = -b/(2 * a);
            Console.WriteLine("There is only one real root: {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("The first root is: {0} and the second is: {1}", x1, x2);
        }
    }
}

