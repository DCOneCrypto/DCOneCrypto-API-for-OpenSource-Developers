using System.Text.Json;

namespace DCOneCrypto.Common.Models;

public class MintTransaction
{
    public string TxHash { get; init; } = string.Empty;
    public ulong TxIndex { get; init; }
    public string PolicyId { get; init; } = string.Empty;
    public string TokenName { get; init; } = string.Empty;
    public string AsciiTokenName { get; init; } = string.Empty;
    public string? Metadata { get; set; }
    public ulong Slot { get; init; }
    public string BlockHash { get; init; } = string.Empty;
}