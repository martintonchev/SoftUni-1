using System;

class ExchangeVariablesValues
{
    static void Main()
    {
        //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.

        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine("a = {0}, b = {1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange a = {0}, b = {1}", a, b);
        //Exchange values without using a third variable
        a = 5;
        b = 10;
        Console.WriteLine("a = {0}, b = {1}", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After exchange a = {0}, b = {1}", a, b);
    }
}

