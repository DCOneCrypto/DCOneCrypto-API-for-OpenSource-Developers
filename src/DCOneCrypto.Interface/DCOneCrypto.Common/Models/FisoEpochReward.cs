using System.Numerics;

namespace DCOneCrypto.Common.Models;

public record FisoEpochReward
{
    public ulong EpochNumber { get; init; }
    public string StakeAddress { get; init; } = string.Empty;
    public string PoolId { get; init; } = string.Empty;
    public BigInteger StakeAmount { get; init; }
    public decimal SharePercentage { get; init; }
    public ulong ShareAmount { get; init; }
}