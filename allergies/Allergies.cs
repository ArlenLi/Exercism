using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private int allergicScore;
    private List<Allergen> allergens = new List<Allergen>();
    public Allergies(int mask)
    {
        allergicScore = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (allergicScore >> (int)allergen & 1) == 1; 
    }

    public Allergen[] List()
    {
        var allergenLength = System.Enum.GetNames(typeof(Allergen)).Length;
        for(int i = 0; i < allergenLength; i++) {
            if(((allergicScore >> i) & 1) == 1) {
                allergens.Add((Allergen)i);
            }
        }
        return allergens.ToArray();
    }
}