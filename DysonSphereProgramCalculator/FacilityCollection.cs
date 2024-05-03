namespace DysonSphereProgramCalculator;

public class FacilityCollection
{
    private static List<Facility> Data = [
        new Facility(Item.PlaneSmelter, FacilityType.Smelter, 20),
        new Facility(Item.AssemblerMk3, FacilityType.Assembler, 15),
        new Facility(Item.QuantumChemicalPlant, FacilityType.ChemicalPlant, 20)
    ];

    public static readonly Dictionary<FacilityType, Facility> Facilities;

    static FacilityCollection()
    {
        Facilities = Data.ToDictionary(_ => _.Type, _ => _);
    }
}