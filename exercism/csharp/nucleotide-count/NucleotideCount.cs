using System;
using System.Linq;
using System.Collections.Generic;

public class NucleotideCount
{
    private List<char> ValidNucleotides => new List<char> { 'A', 'C', 'G', 'T' };

    public NucleotideCount(string sequence)
    {
        if (sequence.Any(c => !ValidNucleotides.Contains(c))) throw new ArgumentException();
        NucleotideCounts = new Dictionary<char, int>();
        ValidNucleotides.ForEach(n => NucleotideCounts[n] = 0);
        sequence.ToList().ForEach(n => NucleotideCounts[n]++);
    }

    public IDictionary<char, int> NucleotideCounts { get; set; }
}