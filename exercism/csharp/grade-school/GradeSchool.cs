using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<int, List<string>> school;

    public GradeSchool()
    {
        school = new Dictionary<int, List<string>>();
    }
    public void Add(string student, int grade)
    {
        if (school.ContainsKey(grade))
        {
            school[grade].Add(student);
        }
        else
        {
            school[grade] = new List<string> { student };
        }
    }

    public IEnumerable<string> Roster()
    {
        return school
            .OrderBy(s => s.Key)
            .Select(g => g.Value)
            .SelectMany(x => x.OrderBy(s => s));
    }

    public IEnumerable<string> Grade(int grade)
    {
        return school.ContainsKey(grade)
            ? school[grade].OrderBy(x => x).ToList()
            : new List<string>();
    }
}