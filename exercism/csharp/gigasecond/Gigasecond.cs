using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        var gigaseconds = 1000000000;
        return birthDate.AddSeconds(gigaseconds);
    }
}