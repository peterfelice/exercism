using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Hey(string statement)
    {
        string reply = "Whatever.";

        if (String.IsNullOrWhiteSpace(statement))
        {
            reply = "Fine. Be that way!";
        }
        else if (statement.ToUpper() == statement && Regex.Matches(statement, @"[a-zA-Z]").Count > 0)
        {
            reply = "Whoa, chill out!";
        }
        else if (statement.Trim().EndsWith("?"))
        {
            reply = "Sure.";
        }

        return reply;
    }
}