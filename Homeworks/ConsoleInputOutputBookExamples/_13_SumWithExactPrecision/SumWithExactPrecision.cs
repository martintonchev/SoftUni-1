using System;

class SumWithExactPrecision
{
    static void Main()
    {
        //TO DO TO DO TO DO TO DO :) ????????????????????????????
        double sum = 1;
        double prevSum = 1;
        do
        {
            prevSum = sum;
            int i = 2;
            sum += 1 / i;
            i++;
            if (Math.Abs(prevSum - sum) < 0.001)
            {
                Console.WriteLine(sum);
                break;
            }
        } while (true);
    }
}

