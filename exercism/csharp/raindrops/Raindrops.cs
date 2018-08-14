using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string Check(int dividend, int divisor, string word)
            => dividend % divisor == 0 ? word : String.Empty;
            
        var txt = String.Empty;
       
        txt += Check(number, 3, "Pling");
        txt += Check(number, 5, "Plang");
        txt += Check(number, 7, "Plong");
        
        return string.IsNullOrWhiteSpace(txt)
            ? number.ToString()
            : txt;
    }
}