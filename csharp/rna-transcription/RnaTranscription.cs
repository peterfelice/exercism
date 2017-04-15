using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Complement
{

    private static Dictionary<char, char> dnaComplementMap = new Dictionary<char, char>() {
        { 'G', 'C' },
        { 'C', 'G' },
        { 'T', 'A' },
        { 'A', 'U' }
    };
    public static string OfDna(string nucleotide)
    {
        StringBuilder sb = new StringBuilder(nucleotide);
        for (int i = 0; i < nucleotide.Length; i ++)
        {
            sb[i] = dnaComplementMap[nucleotide[i]];
        }

        return sb.ToString();
    }

}