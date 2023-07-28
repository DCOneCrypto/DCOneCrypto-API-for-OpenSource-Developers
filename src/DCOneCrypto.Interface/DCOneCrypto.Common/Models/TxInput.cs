namespace DCOneCrypto.Common.Models;

public record TxInput
{
    public string TxHash { get; init; } = string.Empty;
    public string TxOutputHash { get; init; } = string.Empty;
    public ulong TxOutputIndex { get; init; }
    public byte? InlineDatum { get; init; }
    public string BlockHash { get; init; } = string.Empty;
}