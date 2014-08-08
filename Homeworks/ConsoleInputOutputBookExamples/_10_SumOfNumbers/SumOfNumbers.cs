using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter how much numbers you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter number: ");
            double curNum = double.Parse(Console.ReadLine());
            sum += curNum;
        }
        Console.WriteLine("The sum of these {0} numbers is: {1}", n, sum);
    } 
}

