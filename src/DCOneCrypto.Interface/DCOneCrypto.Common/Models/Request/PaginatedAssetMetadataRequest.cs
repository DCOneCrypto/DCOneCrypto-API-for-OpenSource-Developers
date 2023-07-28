namespace DCOneCrypto.Common.Models.Request;

public class PaginatedAssetMetadataRequest : PaginatedRequest
{
    public List<AssetClass> AssetClasses { get; init; } = new();
}