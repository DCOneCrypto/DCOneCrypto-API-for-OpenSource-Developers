namespace DCOneCrypto.Common.Models;

public partial record CollateralTxOut
{
    public string TxHash { get; init; } = string.Empty;
    public ulong Amount { get; init; }
    public string Address { get; init; } = string.Empty;
    public string BlockHash { get; init; } = string.Empty;
}