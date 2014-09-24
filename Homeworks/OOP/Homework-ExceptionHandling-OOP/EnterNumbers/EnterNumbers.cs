namespace EnterNumbers
{
    using System;

    class EnterNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter lower limit!");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter upper limit!");
            int endNumber = int.Parse(Console.ReadLine());
            int num = 0;
            int[] numbers = new int[10];
            int counter = 0;

            while (counter < 10)
            {
                try
                {
                    num = ReadNumber(startNumber, endNumber);
                    startNumber = num;
                    numbers[counter] = num;
                    counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number! The number is too big to fit in int32!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The number is not in the requested range!");
                }
            }
        }

        public static int ReadNumber(int startNumber, int endNumber)
        {
            int number = 0;

            Console.WriteLine("Enter number between [{0}..{1}]", startNumber, endNumber);
            number = int.Parse(Console.ReadLine());

            if (number < startNumber || number > endNumber)
            {
                throw new ArgumentOutOfRangeException("Number should be in the requested range!");
            }

            return number;
        }
    }
}
