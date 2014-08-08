using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal firstMem = 0;
        decimal secondMem = 1;
        decimal nextMem;
        for (int i = 4; i <= 100; i++)
        {
            nextMem = firstMem + secondMem;
            firstMem = secondMem;
            secondMem = nextMem;
            Console.WriteLine(nextMem);
        }
    }
}

