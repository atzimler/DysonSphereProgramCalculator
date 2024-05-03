namespace DysonSphereProgramCalculator;

public class ResourceCalculator
{
    public Dictionary<Item, int> Resources = new();
    public Dictionary<Item, int> Materials = new();
    
    public void Calculate(BuildTreeNode node)
    {
        var item = node.ItemQuantity.Item;
        if (node.Children.Count > 0)
        {
            Materials.TryAdd(item, 0);
            Materials[item] += node.ItemQuantity.Quantity;
            
            foreach (var child in node.Children)
            {
                Calculate(child);
            }

            return;
        }

        Resources.TryAdd(item, 0);
        Resources[item] += node.ItemQuantity.Quantity;
    }
}