namespace DCOneCrypto.Common.Models;

public record LinkAddressPayload
{
    public string? MainnetAddress { get; init; }
    public IEnumerable<string>? TestnetAddresses { get; init; }
}