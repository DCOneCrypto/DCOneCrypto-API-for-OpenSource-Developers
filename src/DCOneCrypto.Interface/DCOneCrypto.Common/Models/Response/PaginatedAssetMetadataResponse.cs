namespace DCOneCrypto.Common.Models.Response;

public class PaginatedAssetMetadataResponse : PaginatedResponse<AssetMetadataResponse>
{

    public string Address { get; init; } = string.Empty;
    public string PolicyId { get; init; } = string.Empty;
}