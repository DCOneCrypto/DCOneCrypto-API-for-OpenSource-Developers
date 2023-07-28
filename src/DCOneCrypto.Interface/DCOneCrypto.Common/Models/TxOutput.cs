namespace DCOneCrypto.Common.Models;

public partial record TxOutput
{
    public string TxHash { get; init; } = string.Empty;
    public ulong TxIndex { get; init; }
    public ulong Index { get; init; }
    public ulong Amount { get; init; }
    public string Address { get; init; } = string.Empty;
    public string? DatumCbor { get; init; }
    public string BlockHash { get; init; } = string.Empty;
}