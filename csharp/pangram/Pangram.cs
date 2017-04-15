using System;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool[] lettersUsed = new bool[26];
        int lettersRemaining = 26;
        for (int i = 0; i < input.Length; i++)
        {
                        
            if (Regex.Matches(input[i].ToString(), @"[a-zA-Z]").Count > 0 &&  !lettersUsed[char.ToLower(input[i]) - 'a'])
            {
                lettersUsed[char.ToLower(input[i])-'a'] = true;
                lettersRemaining--;
                if (lettersRemaining == 0)
                {
                    break;
                }

            }
        }

        return lettersRemaining == 0;

    }
}
