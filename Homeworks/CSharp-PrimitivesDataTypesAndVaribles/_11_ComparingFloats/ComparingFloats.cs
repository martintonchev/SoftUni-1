using System;

class ComparingFloats
{
    static void Main()
    {
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

        Console.WriteLine("Please enter the first double number: ");
        double firstVal = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second double number: ");
        double secondVal = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool equal = false;
        if (Math.Abs(firstVal - secondVal) < eps)
        {
            equal = true;
        }
        Console.WriteLine("Is the two numbers equal? {0}", equal);
    }
}

