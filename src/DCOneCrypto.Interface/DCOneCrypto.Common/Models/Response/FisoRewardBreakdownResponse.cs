namespace DCOneCrypto.Common.Models.Response;

public class FisoRewardBreakdownResponse
{
    public string StakeAddress { get; init; } = string.Empty;
    public List<FisoRewardResponse> FisoRewards { get; init; } = new();
    public double TotalBaseReward { get; init; }
    public double TotalBonusReward { get; init; }
}