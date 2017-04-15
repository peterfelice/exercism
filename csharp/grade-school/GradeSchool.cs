using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    SortedList<string, string> allStudents = new SortedList<string, string>();
    private Dictionary<int, SortedList<string, string>> studentsPerGrade = new Dictionary<int, SortedList<string, string>>();

    public void Add(string student, int grade)
    {
        if (!studentsPerGrade.ContainsKey(grade))
        {
            studentsPerGrade.Add(grade, new SortedList<string, string>());
        }
        studentsPerGrade[grade].Add(student, student);
        allStudents.Add(student, student);
    }

    public IEnumerable<string> Roster()
    {
        return allStudents.Keys;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (studentsPerGrade.ContainsKey(grade))
        {
            return studentsPerGrade[grade].Keys;
        }

        return new List<string>();

    }
}