namespace DCOneCrypto.Common.Models.Response;

public class LeaderBoardResponse
{
    public string TestnetAddress { get; init; } = string.Empty;
    public string? MainnetAddress { get; set; }
    public double Rank { get; set; }
    public decimal BaseReward { get; set; }
    public decimal BaseRewardPercentage { get; set; }
    public decimal BonusReward { get; set; }
    public int TotalNft { get; set; }
    public int Total { get; init; }
    public int Deposit { get; init; }
    public int Redeem { get; init; }
    public int Swap { get; init; }
    public int Batch { get; init; }
}