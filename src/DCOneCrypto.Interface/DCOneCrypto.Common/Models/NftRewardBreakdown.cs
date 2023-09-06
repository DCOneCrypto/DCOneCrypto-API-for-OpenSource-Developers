using System.Text.Json.Serialization;

namespace DCOneCrypto.Common.Models;

public record NftRewardBreakdown
{
    public int BaseReward { get; init; }
    public decimal BonusReward {get; init; }
    public decimal EarlySupporterBonus { get; init; }
    public decimal TotalReward { get; init; }
}