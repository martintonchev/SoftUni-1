using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integer: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter double: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter negative double: ");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1,-10:F2}|{2,-10:F2}|", firstNum, secondNum, thirdNum);
    }
}

