using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{

    SortedDictionary<int, SortedList<string, int>> roster;

    public GradeSchool()
    {
        roster = new SortedDictionary<int, SortedList<string, int>>();
    }

    public void Add(string student, int grade)
    {
        if (!roster.ContainsKey(grade))
            roster.Add(grade, new SortedList<string, int>());
        roster[grade].Add(student, grade);
    }

    public IEnumerable<string> Roster() => roster.Values.SelectMany(x => x.Keys).ToArray();

    public IEnumerable<string> Grade(int grade) => 
        (roster.ContainsKey(grade)) ? roster[grade].Keys.ToArray() : Array.Empty<string>();
}