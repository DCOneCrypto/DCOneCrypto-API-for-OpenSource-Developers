using System.Numerics;

namespace DCOneCrypto.Common.Models;

public class Delegator
{
    public string StakeAddress { get; init; } = string.Empty;
    public string PoolId { get; set; } = string.Empty;
    public ulong StakeAmount { get; init; }
    public ulong Epoch { get; init; }
}