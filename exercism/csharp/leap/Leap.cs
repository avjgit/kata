using System;

public static class Leap
{
    private static bool Divisible(int year, int divisor)
    {
        return year % divisor == 0;
    }

    public static bool IsLeapYear(int year)
    {
        return Divisible(year, 400)
        || Divisible(year, 4)
        && !Divisible(year, 100);
    }
}