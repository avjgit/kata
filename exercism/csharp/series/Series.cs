using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length) throw new ArgumentException();

        var slices = new List<string>();
        for (int i = 0; i + sliceLength <= numbers.Length; i++)
        {
            slices.Add(numbers.Substring(i, sliceLength));
        }
        return slices.ToArray();
    }
}