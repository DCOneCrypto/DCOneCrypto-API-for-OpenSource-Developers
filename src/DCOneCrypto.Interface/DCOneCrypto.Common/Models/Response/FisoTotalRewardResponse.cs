namespace DCOneCrypto.Common.Models.Response;

public class FisoTotalRewardResponse
{
    public string StakeAddress { get; init; } = string.Empty;
    public ulong TotalBaseReward { get; init; }
    public ulong TotalBonusReward { get; init; }
}