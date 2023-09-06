using System.Numerics;
using DCOneCrypto.Common.Enums;

namespace DCOneCrypto.Common.Models;

public record Order
{
    // @TODO: Remove relation
    public string TxHash { get; init; } = string.Empty;
    public ulong Index { get; init; }
    public string Blockhash { get; set; } = string.Empty;
    public OrderType OrderType { get; init; }
    public Block Block { get; set; } = new();
    public Price? Price { get; init; }
    public byte[]? PoolDatum { get; init; }
    public byte[]? OrderDatum { get; init; }
    public string UserAddress { get; init; } = string.Empty;
    public string? BatcherAddress { get; init; }
    public string AssetX { get; init; } = string.Empty;
    public string AssetY { get; init; } = string.Empty;
    public string AssetLq { get; init; } = string.Empty;
    public string PoolNft { get; init; } = string.Empty;
    public string OrderBase { get; init; } = string.Empty;
    public BigInteger ReservesX { get; init; }
    public BigInteger ReservesY { get; init; }
    public BigInteger Liquidity { get; init; }
    public BigInteger OrderX { get; init; }
    public BigInteger OrderY { get; init; }
    public BigInteger OrderLq { get; init; }
    public ulong Slot { get; init; }
}