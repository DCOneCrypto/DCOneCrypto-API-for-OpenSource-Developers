namespace DCOneCrypto.Common.Models.Response;

public record AssetResponse
{
    public string Name { get; init; } = string.Empty;
    public string AsciiName { get; init; } = string.Empty;
    public ulong Amount { get; init; }
    public int MintOrder { get; set; }
}