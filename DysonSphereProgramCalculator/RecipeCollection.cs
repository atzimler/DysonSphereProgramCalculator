namespace DysonSphereProgramCalculator;

public static class RecipeCollection
{
    public static List<Recipe> Recipes =
    [
        new Recipe(new ItemQuantity(Item.AdvancedMiningMachine), 1, [
            new ItemQuantity(Item.TitaniumAlloy, 20),
            new ItemQuantity(Item.FrameMaterial, 10),
            new ItemQuantity(Item.QuantumChip, 4),
            new ItemQuantity(Item.OpticalGraftingCrystal, 40)
        ]),
        new Recipe(new ItemQuantity(Item.Glass), 1, [
            new ItemQuantity(Item.Stone, 2)
        ]),
        
    ];
}