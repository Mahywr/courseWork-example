using System;

class Q1
{
    static void Main()
    {
        const int secInMin = 60;
        const int minInHour = 60;
        const int hourInDay = 24;
        int daysInYear = 365;
        long secInYear = secInMin * minInHour * hourInDay * daysInYear;
        int minInYear = minInHour * hourInDay * daysInYear;
        Console.WriteLine(secInYear + "\n" + minInYear);
        Console.Write(secInYear / minInHour);
    }
}