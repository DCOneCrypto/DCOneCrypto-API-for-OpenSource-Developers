namespace DCOneCrypto.Common.Models;

public record FisoDelegation
{
    public ulong EpochNumber { get; init; }
    public string TxHash { get; init; } = string.Empty;
    public ulong Slot { get; init; }
    public ulong BlockNumber { get; init; }
    public string StakeAddress { get; init; } = string.Empty;
    public string? FromPoolId { get; set; }
    public string ToPoolId { get; set; } = string.Empty;
    public ulong LiveStake { get; set; }
}