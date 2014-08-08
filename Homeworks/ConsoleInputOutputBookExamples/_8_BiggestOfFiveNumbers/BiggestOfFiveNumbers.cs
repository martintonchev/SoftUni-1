using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        int sum = 0;
        int biggestNumber = int.MinValue;
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
            if (curNum > biggestNumber)
            {
                biggestNumber = curNum;
            }
        }
        Console.WriteLine("Biggest number is: {0}", biggestNumber);
    }
}

