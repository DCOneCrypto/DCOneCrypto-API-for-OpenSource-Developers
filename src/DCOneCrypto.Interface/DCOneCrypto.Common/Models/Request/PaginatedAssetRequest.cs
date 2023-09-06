namespace DCOneCrypto.Common.Models.Request;

public class PaginatedAssetRequest : PaginatedRequest
{
    public string PolicyId { get; init; } = string.Empty;
    public string Address { get; init; } = string.Empty;
}