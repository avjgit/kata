using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<int, List<string>> _school;

    public GradeSchool() => _school = new Dictionary<int, List<string>>();

    public void Add(string student, int grade)
    {
        if (!_school.ContainsKey(grade)) _school[grade] = new List<string>();
        _school[grade].Add(student);
    }

    public IEnumerable<string> Roster() => _school.OrderBy(s => s.Key).SelectMany(x => x.Value.OrderBy(s => s));

    public IEnumerable<string> Grade(int grade) => _school.ContainsKey(grade)
        ? _school[grade].OrderBy(x => x).ToList()
        : Enumerable.Empty<string>();
}