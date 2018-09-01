using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets = 'V',
    Radishes = 'R',
    Clover = 'C',
    Grass = 'G'
}

public class KindergartenGarden
{
    private readonly List<string> students = new List<string>
    {
        "Alice","Bob","Charlie","David","Eve","Fred","Ginny","Harriet","Ileana","Joseph","Kincaid","Larry"
    };

    // really relying on requirements "promise" that each kid have same amount of flowers
    private readonly int FLOWERS_COUNT = 2;

    private readonly List<string> plantsRows;

    public KindergartenGarden(string diagram)
    {
        plantsRows = diagram.Split("\n").ToList();
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var plants_start = students.IndexOf(student) * FLOWERS_COUNT;
        var plants = new List<Plant>();
        foreach (var line in plantsRows)
        {
            for (int i = plants_start; i < plants_start + FLOWERS_COUNT; i++)
            {
                plants.Add((Plant)line[i]);
            }
        }
        return plants;
    }
}