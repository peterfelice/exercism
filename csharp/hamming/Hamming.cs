using System;

public static class Hamming
{
    public static int Compute(string firstStrand, string secondStrand)
    {
        int errors = 0;
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
            {
                errors++;
            }
        }
        return errors;
    }
}