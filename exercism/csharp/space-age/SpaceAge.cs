using System;

public class SpaceAge
{
    private long Seconds { get; }

    private const long EARTH_YEAR_SECONDS = 31557600;
    private const double MERCURY_EARTH_YEARS = 0.2408467;
    private const double VENUS_EARTH_YEARS = 0.61519726;
    private const double MARS_EARTH_YEARS = 1.8808158;
    private const double JUPITER_EARTH_YEARS = 11.862615;
    private const double SATURN_EARTH_YEARS = 29.447498;
    private const double URANUS_EARTH_YEARS = 84.016846;
    private const double NEPTUNE_EARTH_YEARS = 164.79132;

    public SpaceAge(long seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        return (double)Seconds / EARTH_YEAR_SECONDS;
    }

    public double OnMercury()
    {
        return OnEarth() / MERCURY_EARTH_YEARS;
    }

    public double OnVenus()
    {
        return OnEarth() / VENUS_EARTH_YEARS;
    }

    public double OnMars()
    {
        return OnEarth() / MARS_EARTH_YEARS;
    }

    public double OnJupiter()
    {
        return OnEarth() / JUPITER_EARTH_YEARS;
    }

    public double OnSaturn()
    {
        return OnEarth() / SATURN_EARTH_YEARS;
    }

    public double OnUranus()
    {
        return OnEarth() / URANUS_EARTH_YEARS;
    }

    public double OnNeptune()
    {
        return OnEarth() / NEPTUNE_EARTH_YEARS;
    }
}