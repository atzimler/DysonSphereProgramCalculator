namespace DysonSphereProgramCalculator;

public class Facilities
{
    public Dictionary<Facility, int> Multiplier = new()
    {
        { Facility.Smelter, 20 },
        { Facility.Assembler, 15 },
        { Facility.ChemicalPlant, 20 }
    };
}