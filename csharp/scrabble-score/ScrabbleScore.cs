using System;
using System.Linq;

public static class Scrabble
{
    private static int[] scores = new int[26];

    static Scrabble()
    {
        for (char c = 'A'; c <= 'Z'; c++)
        {
            if ("AEIOULNRST".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 1;
            }
            else if ("DG".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 2;
            }
            else if ("BCMP".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 3;
            }
            else if ("FHVWY".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 4;
            }
            else if ("K".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 5;
            }
            else if ("JX".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 8;
            }
            else if ("ZQ".IndexOf(c) >= 0)
            {
                scores[c - 'A'] = 10;
            }

        }

    }



    public static int Score(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }
        return input.Sum(x => scores[char.ToLower(x)-'a']);
    }
}