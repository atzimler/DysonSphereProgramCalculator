using MoreLinq;

namespace DysonSphereProgramCalculator;

public static class Program
{
    private static void Main(string[] args)
    {
//        var buildTree = BuildTreeFactory.CreateForRecipe(Item.AdvancedMiningMachine);
        var buildTree = BuildTreeFactory.CreateForRecipe(Item.Processor);

        var recipe = RecipeCollection.Recipes[Item.AdvancedMiningMachine];
        var facility = FacilityCollection.Facilities[recipe.MadeIn];
//        var targetCycleTime = 1.0m * recipe.BaseTime / facility.Multiplier;
        var targetCycleTime = 1m;

        var resourceCalculator = new ResourceCalculator();
        resourceCalculator.Calculate(buildTree.Root);

        PrintResources(resourceCalculator.Resources);
        // PrintProduction(resourceCalculator.Materials, targetCycleTime);

        var productionPlanner = new ProductionPlanner();
        productionPlanner.Plan(buildTree.Root, targetCycleTime);
        
        Console.WriteLine($"Cycle time: {targetCycleTime}");
    }

    private static void PrintProduction(KeyValuePair<Item, int> material, decimal targetCycleTime)
    {
        var recipe = RecipeCollection.Recipes[material.Key];
        var facility = FacilityCollection.Facilities[recipe.MadeIn];
        
        var requiredAmount = material.Value;
        var requiredRuns = Math.Ceiling(1.0m * requiredAmount / recipe.Result.Quantity);
        var totalTime = requiredRuns * recipe.BaseTime;
        var totalTimeOnFacility = 1.0m * totalTime / facility.Multiplier;

        var facilityCount = Math.Ceiling(totalTimeOnFacility / targetCycleTime);
        Console.WriteLine($"{facilityCount} * {facility.Item} => {material.Key}");
    }
    
    private static void PrintResource(KeyValuePair<Item, int> resource)
    {
        var count = resource.Value.ToString();
        while (count.Length < 3)
        {
            count = $" {count}";
        }
        Console.WriteLine($"{count} x {resource.Key}");
    }

    private static void PrintProduction(Dictionary<Item, int> materials, decimal targetCycleTime)
        => materials.ForEach(_ => PrintProduction(_, targetCycleTime));

    private static void PrintResources(Dictionary<Item, int> resources)
        => resources.ForEach(PrintResource);
}