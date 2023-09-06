namespace DCOneCrypto.Common.Models.Response;

public class FisoRewardResponse
{
    public string PoolId { get; init; } = string.Empty;
    public ulong Epoch { get; init; }
    public ulong ActiveStake { get; init; }
    public double BaseReward { get; init; }
    public double BonusReward { get; set; }
}