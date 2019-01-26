using System;

public class Clock
{
    private int MINUTES_OVERLAP = 60;
    private int HOURS_OVERLAP = 24;

    public Clock(int hours, int minutes)
    {
        var minutes_total = HOURS_OVERLAP * MINUTES_OVERLAP + hours * MINUTES_OVERLAP + minutes;
        var hour_less = minutes_total % MINUTES_OVERLAP < 0 ? -1 : 0;
        Hours = (HOURS_OVERLAP + minutes_total / MINUTES_OVERLAP + hour_less) % HOURS_OVERLAP;
        Minutes = (MINUTES_OVERLAP + minutes_total % MINUTES_OVERLAP) % MINUTES_OVERLAP;
    }

    public int Hours { get;  }
    public int Minutes { get;  }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(Hours, Minutes + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(Hours, Minutes + minutesToSubtract);
    }

    public override string ToString()
    {
        return $"{Hours.ToString("D2")}:{Minutes.ToString("D2")}";
    }

    public override bool Equals(Object o)
    {
        var other = o as Clock;
        return other.Hours == Hours && other.Minutes == Minutes;
    }
}