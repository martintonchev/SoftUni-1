using System;

class DeclareVariables
{
    static void Main()
    {
        //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.
        ushort firstNum = 53130;
        sbyte secondNum = -115;
        int thirdNum = 4825932;
        byte forthNum = 97;
        short fifthNum = -10000;
        Console.WriteLine(" First number is: {0}\n second number is: {1}\n third number is: {2}\n forth numbers is: {3}\n fifth number is: {4}\n", firstNum, secondNum, thirdNum, forthNum, fifthNum);
    }
}

