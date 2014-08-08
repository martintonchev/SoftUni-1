using System;

class NulValues
{
    static void Main()
    {
        //Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

        int ?firstValue = null;
        Console.WriteLine(firstValue);
        double? secondValue = null;
        Console.WriteLine(secondValue);
        Console.WriteLine(firstValue + 5);
        Console.WriteLine(firstValue + null);
    }
}

