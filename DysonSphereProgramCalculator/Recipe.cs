namespace DysonSphereProgramCalculator;

public class Recipe
{
    private int _baseCraftingTime; // x * 0.1 seconds
    private readonly List<ItemQuantity> _materials = new();
    private readonly ItemQuantity _result;

    public IReadOnlyList<ItemQuantity> Materials => _materials;
    // TODO: More than just one thing might result from it
    public ItemQuantity Result => _result;

    public Recipe(ItemQuantity result, int baseCraftingTime, IEnumerable<ItemQuantity> materials)
    {
        _result = result;
        _baseCraftingTime = baseCraftingTime;
        _materials.AddRange(materials);
    }
}