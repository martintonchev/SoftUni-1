using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        int sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

