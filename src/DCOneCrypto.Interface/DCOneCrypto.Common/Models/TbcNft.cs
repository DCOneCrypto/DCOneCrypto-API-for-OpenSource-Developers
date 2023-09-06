using System.Text.Json.Serialization;

namespace DCOneCrypto.Common.Models;

public record TbcNft
{
    [JsonPropertyName("assetName")]
    public string AssetName { get; init; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; init; } = string.Empty;

    [JsonPropertyName("rarityRank")]
    public string RarityRank { get; init; } = string.Empty;
}