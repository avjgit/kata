using System;

public class SpaceAge
{
    public long Seconds { get; set; }

    public SpaceAge(long seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        return Seconds/31557600;
    }

    public double OnMercury()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnVenus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}