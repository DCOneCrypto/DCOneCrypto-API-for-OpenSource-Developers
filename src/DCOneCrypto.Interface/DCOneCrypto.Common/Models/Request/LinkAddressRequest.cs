namespace DCOneCrypto.Common.Models.Request;

public record LinkAddressRequest
{
    public string? Address { get; init; }
    public string? Payload { get; init; }
    public CardanoSignedMessage? SignedMessage {get; init;}
}