namespace DysonSphereProgramCalculator;

public class Facility
{
    public Item Item { get; }
    public int Multiplier { get; }
    public FacilityType Type { get; }

    public Facility(Item item, FacilityType type, int multiplier)
    {
        Item = item;
        Type = type;
        Multiplier = multiplier;
    }
}