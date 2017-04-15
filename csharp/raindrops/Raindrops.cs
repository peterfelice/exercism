using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string raindropSpeak = "";
        if (number % 3 == 0)
        {
            raindropSpeak += "Pling";
        }
        if (number % 5 == 0)
        {
            raindropSpeak += "Plang";
        }
        if (number % 7 == 0)
        {
            raindropSpeak += "Plong";
        }
        if (String.IsNullOrWhiteSpace(raindropSpeak))
        {
            raindropSpeak = number.ToString();
        }

        return raindropSpeak;
    }
}