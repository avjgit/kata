using System;
using System.Collections.Generic;

public static class ResistorColor
{
    private static List<string> ResistorsColors = new List<string>
    {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };

    public static int ColorCode(string color) => ResistorsColors.IndexOf(color);

    public static string[] Colors() => ResistorsColors.ToArray();
}