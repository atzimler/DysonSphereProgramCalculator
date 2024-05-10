namespace DysonSphereProgramCalculator;

public class RecipeCollection
{
    // TODO: No support for multiple recipes yet.
    private static readonly List<Recipe> OfficialData =
    [
        #region Resources (during late game)
        new Recipe(Item.Coal),
        new Recipe(Item.CopperOre),
        new Recipe(Item.CriticalPhoton),
        new Recipe(Item.FireIce),
        new Recipe(Item.FractalSilicon),
        new Recipe(Item.GraftingCrystal),
        new Recipe(Item.Hydrogen),
        new Recipe(Item.IronOre),
        new Recipe(Item.KimberliteOre),
        new Recipe(Item.OrganicCrystal),
        new Recipe(Item.Stone),
        new Recipe(Item.SiliconOre),
        new Recipe(Item.StalagmiteCrystal),
        new Recipe(Item.SulfuricAcid),
        new Recipe(Item.TitaniumOre),
        new Recipe(Item.UnipolarMagnet),
        new Recipe(Item.Water),
        #endregion

        #region Items and Materials
        new Recipe(Item.AnnihilationConstraintSphere, 200, FacilityType.Assembler, [
            Item.ParticleContainer,
            Item.Processor
        ]),
        
        new Recipe(new ItemQuantity(Item.AntimatterFuelRod, 2), 240, FacilityType.Assembler, [
            new ItemQuantity(Item.Antimatter, 12),
            new ItemQuantity(Item.Hydrogen, 12),
            Item.AnnihilationConstraintSphere,
            Item.TitaniumAlloy
        ]),
        
        // TODO: This creates the same amount of Hydrogen too, so it can be used for the antimatter fuel rod
        new Recipe(new ItemQuantity(Item.Antimatter, 2), 20, FacilityType.ParticleCollider, [
            new ItemQuantity(Item.CriticalPhoton, 2)
        ]),
        
        new Recipe(new ItemQuantity(Item.CarbonNanotube, 2), 40, FacilityType.ChemicalPlant, [
            new ItemQuantity(Item.StalagmiteCrystal, 6)
        ]),
        
        new Recipe(Item.CasimirCrystal, 40, FacilityType.Assembler, [
            new ItemQuantity(Item.GraftingCrystal, 8),
            new ItemQuantity(Item.Graphene, 2),
            new ItemQuantity(Item.Hydrogen, 12)
        ]),
        
        new Recipe(new ItemQuantity(Item.CircuitBoard, 2), 10, FacilityType.Assembler, [
            new ItemQuantity(Item.IronIngot, 2),
            Item.CopperIngot
        ]),
        
        new Recipe(Item.CopperIngot, 10, FacilityType.Smelter, [
            Item.CopperOre
        ]),
        
        new Recipe(new ItemQuantity(Item.CrystalSilicon, 2), 15, FacilityType.Assembler, [
            Item.FractalSilicon
        ]),
        
        new Recipe(new ItemQuantity(Item.Diamond, 2), 15, FacilityType.Smelter, [
            Item.KimberliteOre
        ]),
        
        new Recipe(new ItemQuantity(Item.Deuterium, 5), 25, FacilityType.ParticleCollider, [
            new ItemQuantity(Item.Hydrogen, 10)
        ]),
        
        new Recipe(new ItemQuantity(Item.DeuteronFuelRod, 2), 120, FacilityType.Assembler, [
            Item.TitaniumAlloy,
            new ItemQuantity(Item.Deuterium, 20),
            new ItemQuantity(Item.SuperMagneticRing)
        ]),
        
        new Recipe(Item.DysonSphereComponent, 80, FacilityType.Assembler, [
            new ItemQuantity(Item.FrameMaterial, 3),
            new ItemQuantity(Item.SolarSail, 3),
            new ItemQuantity(Item.Processor, 3)
        ]),
        
        new Recipe(Item.ElectricMotor, 20, FacilityType.Assembler, [
            new ItemQuantity(Item.IronIngot, 2),
            Item.Gear,
            Item.MagneticCoil
        ]),
        
        new Recipe(Item.ElectromagneticTurbine, 20, FacilityType.Assembler, [
            new ItemQuantity(Item.ElectricMotor, 2),
            new ItemQuantity(Item.MagneticCoil, 2)
        ]),
        
        new Recipe(Item.EnergeticGraphite, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.Coal, 2)
        ]),
        
        new Recipe(Item.FrameMaterial, 60, FacilityType.Assembler, [
            new ItemQuantity(Item.CarbonNanotube, 4),
            Item.TitaniumAlloy,
            Item.HighPuritySilicon
        ]),
        
        new Recipe(Item.Gear, 10, FacilityType.Assembler, [
            Item.IronIngot
        ]),
        
        new Recipe(Item.Glass, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.Stone, 2)
        ]),
        
        new Recipe(new ItemQuantity(Item.Graphene, 2), 20, FacilityType.ChemicalPlant, [
            new ItemQuantity(Item.FireIce, 2)
            // TODO: This has a side product, but I don't have support for that yet.
        ]),
        
        new Recipe(Item.GravitonLens, 60, FacilityType.Assembler, [
            new ItemQuantity(Item.Diamond, 4),
            Item.StrangeMatter
        ]),
        
        new Recipe(new ItemQuantity(Item.GravityMatrix, 2), 240, FacilityType.ResearchLab, [
            Item.GravitonLens,
            Item.QuantumChip
        ]),
        
        new Recipe(Item.HighPuritySilicon, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.SiliconOre, 2)
        ]),
        
        new Recipe(Item.InformationMatrix, 100, FacilityType.ResearchLab, [
            new ItemQuantity(Item.Processor, 2),
            Item.ParticleBroadband
        ]),
        
        new Recipe(Item.IronIngot, 10, FacilityType.Smelter, [
            Item.IronOre        
        ]),
        
        new Recipe(Item.Magnet, 15, FacilityType.Smelter, [
            Item.IronOre
        ]),
        
        new Recipe(new ItemQuantity(Item.MagneticCoil, 2), 10, FacilityType.Assembler, [
            new ItemQuantity(Item.Magnet, 2),
            Item.CopperIngot
        ]),
        
        new Recipe(Item.MicrocrystallineComponent, 20, FacilityType.Assembler, [
            new ItemQuantity(Item.HighPuritySilicon, 2),
            Item.CopperIngot
        ]),
        
        new Recipe(Item.ParticleBroadband, 80, FacilityType.Assembler, [
            new ItemQuantity(Item.CarbonNanotube, 2),
            new ItemQuantity(Item.CrystalSilicon, 2),
            Item.Plastic
        ]),
        
        new Recipe(Item.ParticleContainer, 40, FacilityType.Assembler, [
            new ItemQuantity(Item.UnipolarMagnet, 10),
            new ItemQuantity(Item.CopperIngot, 2)
        ]),
        
        new Recipe(Item.PhotonCombiner, 30, FacilityType.Assembler, [
            Item.GraftingCrystal,
            Item.CircuitBoard
        ]),
        
        new Recipe(Item.PlaneFilter, 120, FacilityType.Assembler, [
            Item.CasimirCrystal,
            new ItemQuantity(Item.TitaniumGlass, 2)
        ]),
        
        new Recipe(Item.Plastic, 30, FacilityType.ChemicalPlant, [
            new ItemQuantity(Item.Oil, 2),
            Item.EnergeticGraphite
        ]),
        
        new Recipe(Item.Processor, 30, FacilityType.Assembler, [
            new ItemQuantity(Item.CircuitBoard, 2),
            new ItemQuantity(Item.MicrocrystallineComponent, 2)
        ]),
        
        new Recipe(Item.QuantumChip, 60, FacilityType.Assembler, [
            new ItemQuantity(Item.Processor, 2),
            new ItemQuantity(Item.PlaneFilter, 2)
        ]),
        
        new Recipe(Item.SmallCarrierRocket, 60, FacilityType.Assembler, [
            new ItemQuantity(Item.DysonSphereComponent, 2),
            new ItemQuantity(Item.DeuteronFuelRod, 4),
            new ItemQuantity(Item.QuantumChip, 2)
        ]),
        
        new Recipe(new ItemQuantity(Item.SolarSail, 2), 40, FacilityType.Assembler, [
            Item.Graphene,
            Item.PhotonCombiner
        ]),
        
        new Recipe(Item.Steel, 30, FacilityType.Smelter, [
            new ItemQuantity(Item.IronIngot, 3)
        ]),
        
        new Recipe(Item.StrangeMatter, 80, FacilityType.ParticleCollider, [
            new ItemQuantity(Item.ParticleContainer, 2),
            new ItemQuantity(Item.IronIngot, 2),
            new ItemQuantity(Item.Deuterium, 10)
        ]),
        
        new Recipe(Item.StructureMatrix, 80, FacilityType.ResearchLab, [
            Item.Diamond,
            Item.TitaniumCrystal
        ]),
        
        new Recipe(Item.SuperMagneticRing, 30, FacilityType.Assembler, [
            new ItemQuantity(Item.ElectromagneticTurbine, 2),
            new ItemQuantity(Item.Magnet, 3),
            Item.EnergeticGraphite
        ]),
        
        new Recipe(new ItemQuantity(Item.TitaniumAlloy, 4), 120, FacilityType.Smelter, [
            new ItemQuantity(Item.TitaniumIngot, 4),
            new ItemQuantity(Item.Steel, 4),
            new ItemQuantity(Item.SulfuricAcid, 8)
        ]),
        
        new Recipe(Item.TitaniumCrystal, 40, FacilityType.Assembler, [
            Item.OrganicCrystal,
            new ItemQuantity(Item.TitaniumIngot, 3)
        ]),
        
        new Recipe(new ItemQuantity(Item.TitaniumGlass, 2), 50, FacilityType.Assembler, [
            new ItemQuantity(Item.Glass, 2),
            new ItemQuantity(Item.TitaniumIngot, 2),
            new ItemQuantity(Item.Water, 2)
        ]),
        
        new Recipe(Item.TitaniumIngot, 20, FacilityType.Smelter, [
            new ItemQuantity(Item.TitaniumOre, 2)        
        ]),
        #endregion

        #region Buildings
        new Recipe(new ItemQuantity(Item.AdvancedMiningMachine), 200, FacilityType.Assembler, [
            new ItemQuantity(Item.TitaniumAlloy, 20),
            new ItemQuantity(Item.FrameMaterial, 10),
            new ItemQuantity(Item.SuperMagneticRing, 10),
            new ItemQuantity(Item.QuantumChip, 4),
            new ItemQuantity(Item.GraftingCrystal, 40)
        ]),
        
        new Recipe(Item.PlanetaryLogisticsStation, 200, FacilityType.Assembler, [
            new ItemQuantity(Item.Steel, 40),
            new ItemQuantity(Item.TitaniumIngot, 40),
            new ItemQuantity(Item.Processor, 40),
            new ItemQuantity(Item.ParticleContainer, 20)
        ]),
        
        new Recipe(Item.PlanetaryShieldGenerator, 100, FacilityType.Assembler, [
            new ItemQuantity(Item.Steel, 20),
            new ItemQuantity(Item.ElectromagneticTurbine, 20),
            new ItemQuantity(Item.SuperMagneticRing, 5),
            new ItemQuantity(Item.ParticleContainer, 5)
        ]),
        
        new Recipe(Item.RayReceiver, 80, FacilityType.Assembler, [
            new ItemQuantity(Item.Steel, 20),
            new ItemQuantity(Item.HighPuritySilicon, 20),
            new ItemQuantity(Item.PhotonCombiner, 10),
            new ItemQuantity(Item.Processor, 5),
            new ItemQuantity(Item.SuperMagneticRing, 20)
        ])
        #endregion
    ];

    public readonly Dictionary<Item, Recipe> Recipes;
    
    public RecipeCollection(IEnumerable<Item> additionalItemsAsResource)
    {
        var recipeData = new List<Recipe>();
        recipeData.AddRange(OfficialData);
        
        Recipes = recipeData.ToDictionary(_ => _.Result.Item, _ => _);
        foreach (var item in additionalItemsAsResource)
        {
            var asResource = new Recipe(item);
            if (!Recipes.TryAdd(item, asResource))
            {
                Recipes[item] = asResource;
            }
        }
    }
}