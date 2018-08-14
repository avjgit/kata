using System;

public static class Raindrops
{
    private static int Number { get; set; }

    private static string Check(int divisor, string word)
        => Number % divisor == 0 ? word : String.Empty;

    public static string Convert(int number)
    {
        Number = number;

        var txt = String.Empty;
       
        txt += Check(3, "Pling");
        txt += Check(5, "Plang");
        txt += Check(7, "Plong");
        
        return string.IsNullOrWhiteSpace(txt)
            ? number.ToString()
            : txt;
    }
}