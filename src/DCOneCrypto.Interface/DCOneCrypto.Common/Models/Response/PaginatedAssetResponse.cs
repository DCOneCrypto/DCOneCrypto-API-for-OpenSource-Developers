namespace DCOneCrypto.Common.Models.Response;

public class PaginatedAssetResponse : PaginatedResponse<AssetResponse>
{

    public string Address { get; init; } = string.Empty;
    public string PolicyId { get; init; } = string.Empty;
}