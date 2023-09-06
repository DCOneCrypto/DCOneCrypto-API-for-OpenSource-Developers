namespace DCOneCrypto.Common.Models;

public record FisoBonus
{
    public string StakeAddress { get; init; } = string.Empty;
    public string PoolId { get; init; } = string.Empty;
}