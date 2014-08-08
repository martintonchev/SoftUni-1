using System;

class QuatesInString
{
    static void Main()
    {
//        Declare two string variables and assign them with following value:
//        The "use" of quotations causes difficulties.
//        Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was           correctly defined.

        string escapedString = "The \"use\" of quatations causes difficulties";
        string citatedString = @"The ""use"" of quatations causes difficulties";
        Console.WriteLine(escapedString);
        Console.WriteLine(citatedString);
    }
}

