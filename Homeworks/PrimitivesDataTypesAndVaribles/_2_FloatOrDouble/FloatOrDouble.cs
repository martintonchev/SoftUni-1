using System;

class FloatOrDouble
{
    static void Main()
    {
        //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        double firstNum = 34.567839023;
        float secondNum = 12.345f;
        float thirdNum = 8923.1234857f;
        float forthNum = 3456.091f;
        Console.WriteLine(" First number is {0}\n second number is {1}\n third number is {2}\n forth number is {3}\n", firstNum, secondNum, thirdNum, forthNum);
    }
}

