using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate= 32,
    Pollen= 64,
    Cats = 128
}

public class Allergies
{
    int allergiesMask;
 
    public Allergies(int mask) => allergiesMask = mask;

    public bool IsAllergicTo(Allergen allergen) => ((int)allergen & allergiesMask) > 0;

    public Allergen[] List()
    {
        var allergies = new List<Allergen>();
        foreach (Allergen a in (Allergen[])Enum.GetValues(typeof(Allergen)))
            if(IsAllergicTo(a)) allergies.Add(a);
        return allergies.ToArray();

        //IEnumerable<int> x = Enum.GetValues(typeof(Allergen));
        //x.Where(z => z.is)

        //.ToList<Allergen>().Where(IsAllergicTo).ToArray()
    }
}