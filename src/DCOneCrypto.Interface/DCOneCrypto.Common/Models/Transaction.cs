namespace DCOneCrypto.Common.Models;

public record Transaction
{
    public string Hash { get; init; } = string.Empty;
    public ulong Index { get; init; }
    public ulong Fee { get; init; }
    public string BlockHash { get; init; } = string.Empty;
    public bool HasCollateralOutput { get; init; }
    public string? Metadata { get; init; }
    public bool IsValid { get; init; }
}