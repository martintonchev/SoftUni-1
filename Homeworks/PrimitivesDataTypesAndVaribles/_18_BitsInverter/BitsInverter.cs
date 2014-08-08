using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        string allBinary = "";
        for (int i = 0; i < n; i++)
        {
            int curNum = int.Parse(Console.ReadLine());
            string curBinary = Convert.ToString(curNum, 2).PadLeft(8, '0');
            allBinary += curBinary;

        }
        char[] binaryValues = new char[allBinary.Length];
        for (int i = 0; i < allBinary.Length; i++)
        {
            binaryValues[i] = allBinary[i];
        }

        for (int i = 0; i < binaryValues.Length; i++)
        {
            if (binaryValues[i] == '0')
            {
                binaryValues[i] = '1';
            }
            else
            {
                binaryValues[i] = '0';
            }
            i += step - 1;
        }

        string[] newBinary = new string[n];

        for (int i = 0, j = 0; i < binaryValues.Length; i+=8, j++)
        {
            newBinary[j] = binaryValues[i].ToString() + binaryValues[i + 1].ToString() + binaryValues[i + 2].ToString()+ binaryValues[i + 3].ToString() + binaryValues[i + 4].ToString() + binaryValues[i + 5].ToString() +binaryValues[i + 6].ToString() + binaryValues[i + 7].ToString();
            if (j >= n)
            {
                break;
            }
        }

        for (int i = 0; i < newBinary.Length; i++)
        {
            int curNumber = Convert.ToInt32(newBinary[i], 2);
            Console.WriteLine(curNumber);
        }
    }
}

