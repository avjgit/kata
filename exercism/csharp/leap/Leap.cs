using System;

public static class Leap
{
    private static int Year;

    private static bool Divisible(int divisor)
    {
        return Year % divisor == 0;
    }

    public static bool IsLeapYear(int year)
    {
        Year = year;

        return Divisible(400)
        || Divisible(4)
        && !Divisible(100);
    }
}