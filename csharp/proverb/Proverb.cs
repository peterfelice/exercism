using System;
using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    private static List<string> proverb = new List<string>()
    {
        "For want of a nail the shoe was lost.",
        "For want of a shoe the horse was lost.",
        "For want of a horse the rider was lost.",
        "For want of a rider the message was lost.",
        "For want of a message the battle was lost.",
        "For want of a battle the kingdom was lost.",
        "And all for the want of a horseshoe nail."
};

    public static string Line(int line)
    {
        return proverb[line - 1];
    }

    public static string AllLines()
    {
        return proverb.Aggregate((i, j) => i + "\n" + j);
    }
}