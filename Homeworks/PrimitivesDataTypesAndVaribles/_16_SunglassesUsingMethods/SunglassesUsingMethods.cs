using System;

class SunglassesUsingMethods
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                PrintTopBottomPart(n);
            }
            else
            {
                PrintMiddlePart(i, n);
            }
        }
    }

    private static void PrintMiddlePart(int i, int n)
    {
        string frame = "*";
        string lense = new String('/', 2 * n - 2);
        string middle = new String('|', n);
        string empty = new String(' ', n);
        Console.Write(frame);
        Console.Write(lense);
        Console.Write(frame);
        if (i == n / 2)
        {
            Console.Write(middle);
        }
        else
        {
            Console.Write(empty);
        }
        Console.Write(frame);
        Console.Write(lense);
        Console.Write(frame);
        Console.WriteLine();
    }

    private static void PrintTopBottomPart(int n)
    {
        string frame = new String('*', 2 * n);
        string emptySpace = new String(' ', n);
        Console.Write(frame);
        Console.Write(emptySpace);
        Console.Write(frame);
        Console.WriteLine();
    }
}

