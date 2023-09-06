namespace DCOneCrypto.Common.Models;

public record AddressVerification
{
    public string TestnetAddress { get; init; } = string.Empty;
    public string? MainnetAddress { get; init; }
    public string TestnetSignedData { get; init; } = string.Empty;
    public string MainnetSignedData { get; init; } = string.Empty;
}