using System.Text.Json;

namespace DCOneCrypto.Common.Models.Response;

public record VerifyMessageResponse
{
    public bool HasSigned { get; init; }
}