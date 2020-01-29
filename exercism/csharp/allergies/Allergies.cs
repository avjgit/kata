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

    public Allergen[] List() => ((Allergen[])Enum.GetValues(typeof(Allergen))).Where(IsAllergicTo).ToArray();
}