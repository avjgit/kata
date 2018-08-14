using System;

public class Robot
{
    private Random r;

    private string name;

    public Robot()
    {
        r = new Random();
    }

    public string Name 
    {
        get
        {
            if (name == null)
            {
                name = GenerateName();
            }
            return name;
        }
    }

    public void Reset()
    {
        name = GenerateName();
    }

    private string GenerateName()
    {
        return GetNamePart(Letter, 2) + GetNamePart(Digit,4);
    }

    private string GetNamePart(Func<string> getSymbol, int callingTimes)
    {
        string namePart = String.Empty;
        for (int i = 0; i < callingTimes; i++)
        {
            namePart += getSymbol();
        }
        return namePart;
    }

    private string GetRandom(string options) => options[r.Next(0, options.Length)].ToString();

    private string Letter() => GetRandom("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

    private string Digit() => GetRandom("0123456789");
}