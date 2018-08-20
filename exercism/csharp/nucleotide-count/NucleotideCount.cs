using System;
using System.Collections.Generic;

public class NucleotideCount
{
    private readonly string sequence;

    private const char ADENINE = 'A';
    private const char CYTOSINE = 'C';
    private const char GUANINE = 'G';
    private const char THYMINE = 'T';

    Dictionary<char, int> nucleotideCounts;
    private List<char> ValidNucleotides => new List<char>
    {
        ADENINE, CYTOSINE, GUANINE, THYMINE
    };

    public NucleotideCount(string sequence)
    {
        foreach (char c in sequence)
        {
            if (!ValidNucleotides.Contains(c))
            {
                throw new ArgumentException();
            }
        }

        this.sequence = sequence;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            if (nucleotideCounts == null)
                CountNucleotides();
            return nucleotideCounts;
        }
    }

    private void CountNucleotides()
    {
        nucleotideCounts = new Dictionary<char, int>
        {
            [ADENINE] = 0,
            [CYTOSINE] = 0,
            [GUANINE] = 0,
            [THYMINE] = 0
        };

        void count(char nucleotide) => nucleotideCounts[nucleotide] = nucleotideCounts[nucleotide] + 1;

        foreach (var nucleotide in sequence)
        {
            switch (nucleotide)
            {
                case ADENINE: count(ADENINE); break;
                case CYTOSINE: count(CYTOSINE); break;
                case GUANINE: count(GUANINE); break;
                case THYMINE: count(THYMINE); break;
                default:
                    break;
            }
        }
    }
}