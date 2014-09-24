using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            string s = Console.ReadLine();
            double num = double.Parse(s);
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("Sqrt = " + Math.Sqrt(num));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number should be positive!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

