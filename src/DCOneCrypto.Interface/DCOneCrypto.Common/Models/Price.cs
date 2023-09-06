using System.Numerics;

namespace DCOneCrypto.Common.Models;

public record Price
{
    // @TODO: Remove relation
    public string TxHash { get; init; } = string.Empty;
    public ulong Index { get; init; }
    public Order Order { get; init; } = new();
    public decimal PriceX { get; init; }
    public decimal PriceY { get; init; }
}