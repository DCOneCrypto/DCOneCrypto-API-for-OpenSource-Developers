namespace DCOneCrypto.Common.Models;

public record BadgerAddressVerification
{
    public string Address { get; init; } = string.Empty;
    public string? LinkAddress { get; init; }
    public string? StakeAddress { get; init; }
    public string? LinkStakeAddress { get; init; }
    public string TxHash { get; init; } = string.Empty;
    public ulong Slot { get; init; }
    public string BlockHash { get; init; } = string.Empty;
}