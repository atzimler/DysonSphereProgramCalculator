namespace DysonSphereProgramCalculator;

public class Recipe
{
    private readonly List<ItemQuantity> _materials = new();

    public int BaseTime { get; } // x * 0.1 seconds
    public FacilityType MadeIn { get; }
    public bool IsResource { get; }
    public IReadOnlyList<ItemQuantity> Materials => _materials;
    // TODO: More than just one thing might result from it
    public ItemQuantity Result { get; }

    public Recipe(ItemQuantity result, int baseTime, FacilityType madeIn, IEnumerable<ItemQuantity> materials)
    {
        MadeIn = madeIn;
        Result = result;
        BaseTime = baseTime;
        _materials.AddRange(materials);
    }

    public Recipe(Item item)
    {
        MadeIn = FacilityType.Resource;
        Result = new ItemQuantity(item);
        BaseTime = -1;
        IsResource = true;
    }
}