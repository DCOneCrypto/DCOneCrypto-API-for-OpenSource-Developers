using System.Numerics;

namespace DCOneCrypto.Common.Models;

public class PoolStake
{
    public string PoolId { get; init; } = string.Empty;
    public ulong StakeAmount { get; init; }
}