using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> numbers, int max)
    {
        var multiples = new HashSet<int>();
        foreach (var number in numbers)
        {
            var multiple = number;
            while(multiple < max)
            {
                multiples.Add(multiple);
                multiple += number;
            }
        }
        return multiples.Sum();
    }
}