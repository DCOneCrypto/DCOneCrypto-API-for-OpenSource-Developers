namespace DCOneCrypto.Common.Models.Request;

public class PaginatedRequestBase
{

    public int Offset { get; init; }
    public int Limit { get; init; }
}