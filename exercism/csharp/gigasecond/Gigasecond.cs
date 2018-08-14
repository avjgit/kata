using System;

public static class Gigasecond
{
    private const int GIGASECONDS = 1_000_000_000;

    public static DateTime Add(DateTime birthDate)
    {
        return birthDate.AddSeconds(GIGASECONDS);
    }
}