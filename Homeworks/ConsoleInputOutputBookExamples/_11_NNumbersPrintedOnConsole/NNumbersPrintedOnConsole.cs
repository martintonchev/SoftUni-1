using System;

class NNumbersPrintedOnConsole
{
    static void Main()
    {
        Console.WriteLine("Please enter number n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

