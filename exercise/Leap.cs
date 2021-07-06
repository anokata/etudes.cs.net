using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isDivBy4 = year % 4 == 0;
        bool isDivBy100 = year % 100 == 0;
        bool isDivBy400 = year % 400 == 0;
        return isDivBy400 || (!isDivBy100 && isDivBy4);
    }
}