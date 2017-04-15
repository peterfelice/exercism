using System;

public static class Gigasecond
{
    public static DateTime Date(DateTime birthDate)
    {
        return birthDate.AddSeconds((int)Math.Pow(10, 9));
    }
}