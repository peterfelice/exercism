using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {
        bool[] matches = new bool[max];
        foreach (int multiple in multiples)
        {
            for (int i = multiple; i < max; i += multiple)
            {
                matches[i] = true;
            }
        }

        int sum = 0;
        for (int i = 1; i < max; i++)
        {
            if (matches[i])
            {
                sum += i;
            }
        }

        return sum;

    }
}