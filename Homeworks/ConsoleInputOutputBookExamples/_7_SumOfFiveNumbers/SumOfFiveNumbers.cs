using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            int curNum = 0;
            bool isNumber;
            do
            {
                Console.WriteLine("Please enter {0} number: ", i);
                string inputString = Console.ReadLine();
                isNumber = Int32.TryParse(inputString, out curNum);
            } while (!isNumber);
            sum += curNum;
        }
        Console.WriteLine(sum);
    }
}

