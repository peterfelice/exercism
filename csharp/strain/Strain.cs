using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> keep = new List<T>();
        foreach (T t in collection)
        {
            if (predicate(t))
            {
                keep.Add(t);
            }
        }
        return keep;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> discard = new List<T>();
        foreach (T t in collection)
        {
            if (!predicate(t))
            {
                discard.Add(t);
            }
        }
        return discard;
    }
}