using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int count = 0;
        for (int a = 1; a <= 7; a++)
        {
            for (int b = 1; b <= 7; b++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    string abc = a + "" + b + c;
                    int def = int.Parse(abc) + diff;
                    int ghi = int.Parse(abc) + 2 * diff;
                    int f = def % 10;
                    def = def / 10;
                    int e = def % 10;
                    int d = def / 10;
                    int i = ghi % 10;
                    ghi = ghi / 10;
                    int h = ghi % 10;
                    int g = ghi / 10;
                    if (a + b + c + d + e + f + g + h + i == sum && d >= 1 && d <= 7 && e >= 1 && e <= 7 && f >= 1 && f <= 7 && g >= 1 && g <= 7 && h >= 1 && h <= 7 && i >= 1 && i <= 7)
                    {
                        count = 1;
                        Console.WriteLine(a + "" + b + c + d + e + f + g + h + i);   
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

