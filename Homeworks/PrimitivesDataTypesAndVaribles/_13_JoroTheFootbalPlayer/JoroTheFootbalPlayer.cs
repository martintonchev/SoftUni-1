using System;

class JoroTheFootbalPlayer
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometwonWeekends = int.Parse(Console.ReadLine());
        double holidayPlays = holidays / 2.00;
        int normalWeekends = 52 - hometwonWeekends;
        double normalWeekendsPlays = normalWeekends * (2.00 / 3.00);
        int hometownPlays = hometwonWeekends;
        double totalPlays = holidayPlays + normalWeekendsPlays + hometownPlays;
        int total = (int)totalPlays;
        if (leapYear == "t")
        {
            total += 3;
        }
        Console.WriteLine(total);
    }
}

