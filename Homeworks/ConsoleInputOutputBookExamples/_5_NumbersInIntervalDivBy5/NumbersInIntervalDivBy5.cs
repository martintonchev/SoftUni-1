using System;

class NumbersInIntervalDivBy5
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                break;
            }
            int counter = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("Numbers between {0} and {1} which are not dividable by 5 are: {2}", firstNum, secondNum, counter);
        }
    }
}

