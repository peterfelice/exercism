using System;
using System.Collections.Generic;

public class Robot
{

    private static HashSet<string> nameHistory = new HashSet<string>();

    private string name = "";

    public string Name
    {
        get
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                name = "";
                do
                {
                    Random random = new Random();                    
                    name += (char) ('A' + random.Next(0, 25));
                    name += (char) ('A' + random.Next(0, 25));
                    name += random.Next(0, 999).ToString("D3");
                } while (nameHistory.Contains(name));
                nameHistory.Add(name);
            }

            return name;
        }
    }

    public void Reset()
    {
        name = "";
    }
}