using MoreLinq;

namespace DysonSphereProgramCalculator;

public static class Program
{
    private static void Main(string[] args)
    {
        var recipeCollection = new RecipeCollection(new[] { Item.Processor });
        // var recipeCollection = new RecipeCollection(Array.Empty<Item>());
        var buildTreeFactory = new BuildTreeFactory(recipeCollection);
        var buildTree = buildTreeFactory.CreateForRecipe(Item.StructureMatrix);
        var targetCycleTime = 1m;

        var resourceCalculator = new ResourceCalculator();
        resourceCalculator.Calculate(buildTree.Root);

        PrintResources(resourceCalculator.Resources);

        var productionPlanner = new ProductionPlanner(recipeCollection);
        productionPlanner.Plan(buildTree.Root, targetCycleTime);
        
        Console.WriteLine($"Cycle time: {targetCycleTime}");
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

    private static void PrintResources(Dictionary<Item, int> resources)
        => resources.ForEach(PrintResource);
}