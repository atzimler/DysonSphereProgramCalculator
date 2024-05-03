namespace DysonSphereProgramCalculator;

public class RecipeCollection
{
    private static readonly List<Recipe> OfficialData =
    [
        new Recipe(Item.IronOre),
        new Recipe(Item.CopperOre),
        new Recipe(Item.Stone),
        new Recipe(Item.Coal),
        new Recipe(Item.SiliconOre),
        new Recipe(Item.TitaniumOre),
        new Recipe(Item.Water),
        new Recipe(Item.Hydrogen),
        new Recipe(Item.SulfuricAcid),
        new Recipe(Item.Graphene),
        new Recipe(Item.OpticalGraftingCrystal),
        new Recipe(Item.StalagmiteCrystal),

        new Recipe(Item.IronIngot, 10, FacilityType.Smelter, [
            new ItemQuantity(Item.IronOre)        
        ]),
        
        new Recipe(Item.CopperIngot, 10, FacilityType.Smelter, [
            new ItemQuantity(Item.CopperOre)
        ]),
        
        new Recipe(Item.EnergeticGraphite, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.Coal, 2)
        ]),
        
        new Recipe(Item.HighPuritySilicon, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.SiliconOre, 2)
        ]),
        
        new Recipe(Item.TitaniumIngot, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.TitaniumOre, 2)        
        ]),
        
        new Recipe(Item.Magnet, 15, FacilityType.Smelter, [
            new ItemQuantity(Item.IronOre)
        ]),
        
        new Recipe(new ItemQuantity(Item.MagneticCoil, 2), 10, FacilityType.Assembler, [
            new ItemQuantity(Item.Magnet, 2),
            new ItemQuantity(Item.CopperIngot)
        ]),
        
        new Recipe(new ItemQuantity(Item.Glass), 20, FacilityType.Smelter, [
            new ItemQuantity(Item.Stone, 2)
        ]),
        
        new Recipe(new ItemQuantity(Item.TitaniumAlloy, 4), 120, FacilityType.Smelter, [
            new ItemQuantity(Item.TitaniumIngot, 4),
            new ItemQuantity(Item.Steel, 4),
            new ItemQuantity(Item.SulfuricAcid, 8)
        ]),
        
        new Recipe(Item.Steel, 30, FacilityType.Smelter, [
            new ItemQuantity(Item.IronIngot, 3)
        ]),
        
        new Recipe(new ItemQuantity(Item.CircuitBoard, 2), 10, FacilityType.Assembler, [
            new ItemQuantity(Item.IronIngot, 2),
            new ItemQuantity(Item.CopperIngot)
        ]),
        
        new Recipe(Item.ElectricMotor, 20, FacilityType.Assembler, [
            new ItemQuantity(Item.IronIngot, 2),
            new ItemQuantity(Item.Gear),
            new ItemQuantity(Item.MagneticCoil)
        ]),
        
        new Recipe(Item.MicrocrystallineComponent, 20, FacilityType.Assembler, [
            new ItemQuantity(Item.HighPuritySilicon, 2),
            new ItemQuantity(Item.CopperIngot)
        ]),
        
        new Recipe(Item.CasimirCrystal, 40, FacilityType.Assembler, [
            new ItemQuantity(Item.OpticalGraftingCrystal, 8),
            new ItemQuantity(Item.Graphene, 2),
            new ItemQuantity(Item.Hydrogen, 12)
        ]),
        
        new Recipe(new ItemQuantity(Item.CarbonNanotube, 2), 40, FacilityType.ChemicalPlant, [
            new ItemQuantity(Item.StalagmiteCrystal, 6)
        ]),
        
        new Recipe(Item.Gear, 10, FacilityType.Assembler, [
            new ItemQuantity(Item.IronIngot)
        ]),
        
        new Recipe(Item.ElectromagneticTurbine, 20, FacilityType.Assembler, [
            new ItemQuantity(Item.ElectricMotor, 2),
            new ItemQuantity(Item.MagneticCoil, 2)
        ]),
        
        new Recipe(Item.Processor, 30, FacilityType.Assembler, [
            new ItemQuantity(Item.CircuitBoard, 2),
            new ItemQuantity(Item.MicrocrystallineComponent, 2)
        ]),
        
        new Recipe(Item.SuperMagneticRing, 30, FacilityType.Assembler, [
            new ItemQuantity(Item.ElectromagneticTurbine, 2),
            new ItemQuantity(Item.Magnet, 3),
            new ItemQuantity(Item.EnergeticGraphite)
        ]),
        
        new Recipe(new ItemQuantity(Item.TitaniumGlass, 2), 50, FacilityType.Assembler, [
            new ItemQuantity(Item.Glass, 2),
            new ItemQuantity(Item.TitaniumIngot, 2),
            new ItemQuantity(Item.Water, 2)
        ]),
        
        new Recipe(Item.PlaneFilter, 120, FacilityType.Assembler, [
            new ItemQuantity(Item.CasimirCrystal),
            new ItemQuantity(Item.TitaniumGlass, 2)
        ]),
        
        new Recipe(Item.QuantumChip, 60, FacilityType.Assembler, [
            new ItemQuantity(Item.Processor, 2),
            new ItemQuantity(Item.PlaneFilter, 2)
        ]),
        
        new Recipe(Item.FrameMaterial, 60, FacilityType.Assembler, [
            new ItemQuantity(Item.CarbonNanotube, 4),
            new ItemQuantity(Item.TitaniumAlloy),
            new ItemQuantity(Item.HighPuritySilicon)
        ]),
        
        new Recipe(new ItemQuantity(Item.AdvancedMiningMachine), 200, FacilityType.Assembler, [
            new ItemQuantity(Item.TitaniumAlloy, 20),
            new ItemQuantity(Item.FrameMaterial, 10),
            new ItemQuantity(Item.SuperMagneticRing, 10),
            new ItemQuantity(Item.QuantumChip, 4),
            new ItemQuantity(Item.OpticalGraftingCrystal, 40)
        ])
    ];

    public readonly Dictionary<Item, Recipe> Recipes;
    
    public RecipeCollection()
    {
        var recipeData = new List<Recipe>();
        recipeData.AddRange(OfficialData);
        
        Recipes = recipeData.ToDictionary(_ => _.Result.Item, _ => _);
    }
}