using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}


public class Garden
{

    private static Dictionary<char, Plant> map = new Dictionary<char, Plant>()
    {
        {'V', Plant.Violets},
        {'R', Plant.Radishes},
        {'C', Plant.Clover},
        {'G', Plant.Grass},
    };


    private List<string> children;
    private string windowSills;

    public Garden(IEnumerable<string> children, string windowSills)
    {
        this.children = children.OrderBy(x => x).ToList();
        this.windowSills = windowSills;
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        int index = children.FindIndex(x => x == child);
        List<Plant> plants = new List<Plant>();
        if (index >= 0 && (index + 1) * 4 < windowSills.Length)
        {
            plants.Add(map[windowSills[index * 2]]);
            plants.Add(map[windowSills[index * 2 + 1]]);
            plants.Add(map[windowSills[(windowSills.Length / 2 + 1) + index * 2]]);
            plants.Add(map[windowSills[(windowSills.Length / 2 + 1) + index * 2 + 1]]);
        }
        return plants;
    }

    public static Garden DefaultGarden(string windowSills)
    {
        List<string> children = new[] { "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry" }.ToList();
        return new Garden(children, windowSills);

    }
}