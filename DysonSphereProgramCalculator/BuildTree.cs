namespace DysonSphereProgramCalculator;

public class BuildTreeNode
{
    public ItemQuantity ItemQuantity { get; set; }
    public List<BuildTreeNode> Children = new();
}

public class BuildTree
{
    public BuildTreeNode Root { get; set; }
}
