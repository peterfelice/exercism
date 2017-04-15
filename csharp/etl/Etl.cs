using System;
using System.Linq;
using System.Collections.Generic;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
        Dictionary<string, int> newScores = new Dictionary<string, int>();
        foreach (int key in old.Keys)
        {
            foreach (string s in old[key])
            {
                newScores.Add(s.ToLower(), key);
            }
        }

        return newScores;
    }
}