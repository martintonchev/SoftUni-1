using System;

class BitsInverterSecondSolution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int count = -1;

        for (int i = 0; i < n; i++)
        {
            int curNumber = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                count++;
                if (count == 0 || count % step == 0)
                {
                    curNumber = curNumber ^ (1 << j);
                }
            }
            Console.WriteLine(curNumber);
        }
    }
}

