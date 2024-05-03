using System.Text;

namespace DysonSphereProgramCalculator;

public class ProductionPlanner(RecipeCollection recipeCollection)
{
    private ItemQuantity FacilityCount(BuildTreeNode node, decimal cycleTime)
    {
        var recipe = recipeCollection.Recipes[node.ItemQuantity.Item];
        var facility = FacilityCollection.Facilities[recipe.MadeIn];

        var requiredAmount = node.ItemQuantity.Quantity;
        var requiredRuns = Math.Ceiling(1.0m * requiredAmount / recipe.Result.Quantity);
        var totalTime = requiredRuns * recipe.BaseTime;
        var totalTimeOnFacility = 1.0m * totalTime / facility.Multiplier;

        return new ItemQuantity(facility.Item, (int)Math.Ceiling(totalTimeOnFacility / cycleTime));
    }

    public void Plan(BuildTreeNode node, decimal cycleTime, string padding = "", string branch = "")
    {
        if (node.Children.Count == 0)
        {
            Console.WriteLine($"{padding}{branch} <= {node.ItemQuantity.Item}");
        }
        else
        {
            var facility = FacilityCount(node, cycleTime);
            Console.WriteLine($"{padding}{branch}{facility.Item} * {facility.Quantity} => {node.ItemQuantity.Item}");
        }

        for (var childIndex = 0; childIndex < node.Children.Count; childIndex++)
        {
            var nextPadding = branch.Length == 0 || branch[0] == '`' ? $"{padding}  " : $"{padding}| ";
            var nextBranch = childIndex == node.Children.Count - 1 ? "`-" : "+-";
            Plan(node.Children[childIndex], cycleTime, nextPadding, nextBranch);
        }
    }
}