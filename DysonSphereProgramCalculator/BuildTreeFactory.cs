namespace DysonSphereProgramCalculator;

public class BuildTreeFactory(RecipeCollection recipeCollection)
{
    private void AddRecipeToBuildTreeNode(BuildTreeNode node, ItemQuantity itemQuantity)
    {
        node.ItemQuantity = itemQuantity;
        var recipe = recipeCollection.Recipes[itemQuantity.Item];
        var multiplier = (int)Math.Ceiling(1.0m * itemQuantity.Quantity / recipe.Result.Quantity);

        foreach (var material in recipe.Materials)
        {
            var childNode = new BuildTreeNode();
            node.Children.Add(childNode);
            
            AddRecipeToBuildTreeNode(childNode, material * multiplier);
        }
    }
    
    public BuildTree CreateForRecipe(Item item)
    {
        var result = new BuildTree
        {
            Root = new BuildTreeNode()
        };

        AddRecipeToBuildTreeNode(result.Root, new ItemQuantity(item));

        return result;
    }
}