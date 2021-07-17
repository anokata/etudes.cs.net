using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs=1,
    Peanuts=2,
    Shellfish=4,
    Strawberries=8,
    Tomatoes=16,
    Chocolate=32,
    Pollen=64,
    Cats=128
}

public class Allergies
{

    private int _mask;
    
    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
        => (_mask & (byte)allergen) != 0;

    private Allergen NameToAllergen(string name) => (Allergen)Enum.Parse(typeof(Allergen), name);

    public Allergen[] List()
        => Enum.GetNames(typeof(Allergen))
            .Where(name => (IsAllergicTo(NameToAllergen(name))))
            .Select(NameToAllergen).ToArray<Allergen>();
}