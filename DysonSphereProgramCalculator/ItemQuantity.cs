namespace DysonSphereProgramCalculator;

public record ItemQuantity(Item Item, int Quantity = 1)
{
    public static ItemQuantity operator *(ItemQuantity left, int multiplier)
        => left with { Quantity = left.Quantity * multiplier };

    public static implicit operator ItemQuantity(Item item) => new(item);
}