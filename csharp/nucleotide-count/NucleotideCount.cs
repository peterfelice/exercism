using System;
using System.Collections.Generic;

public class DNA
{
    private Dictionary<char, int> nucleotideCounts;
    public DNA(string sequence)
    {
        nucleotideCounts = new Dictionary<char, int>()
        {
            {'A', 0 },
            {'C', 0 },
            {'G', 0 },
            {'T', 0 }
        };

        foreach (char c in sequence)
        {
            nucleotideCounts[c]++;
        }
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return nucleotideCounts;
        }
    }

    public int Count(char nucleotide)
    {
        int count;
        if (!NucleotideCounts.TryGetValue(nucleotide, out count))
        {
            throw new InvalidNucleotideException();
        }
        return count;
    }
}

public class InvalidNucleotideException : Exception { }
