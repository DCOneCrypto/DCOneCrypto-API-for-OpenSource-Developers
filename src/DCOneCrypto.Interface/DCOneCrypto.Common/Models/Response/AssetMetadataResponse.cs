using System.Text.Json;

namespace DCOneCrypto.Common.Models.Response;

public class AssetMetadataResponse
{
    public string PolicyId { get; init; } = string.Empty;
    public string TokenName { get; init; } = string.Empty;
    public string AsciiTokenName { get; init; } = string.Empty;
    public string? Metadata { get; init; } = string.Empty;
}