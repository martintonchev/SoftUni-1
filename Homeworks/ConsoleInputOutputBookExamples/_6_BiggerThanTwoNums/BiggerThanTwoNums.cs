using System;

class BiggerThanTwoNums
{
    static void Main()
    {
        //Console.WriteLine("Please enter first number: ");
        //int firstNum = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter second number: ");
        //int secondNum = int.Parse(Console.ReadLine());
        //int biggerNum = firstNum;
        //if (secondNum > firstNum)
        //{
        //    biggerNum = secondNum;
        //}
        //Console.WriteLine("Bigger number is: {0}", biggerNum);
        //not using conditional statement
        Console.WriteLine("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Bigger number is: {0}", (firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber))/2);
        Console.WriteLine("Smaller number is: {0}", (firstNumber + secondNumber - Math.Abs(firstNumber - secondNumber)) / 2);
    }
}

