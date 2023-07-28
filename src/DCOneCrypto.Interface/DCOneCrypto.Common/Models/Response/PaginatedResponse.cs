namespace DCOneCrypto.Common.Models.Response;

public class PaginatedResponse<T>
{
    public IEnumerable<T> Result { get; init; } = new List<T>();
    public int TotalCount { get; init; }
}