namespace DCOneCrypto.Common.Models;

public partial record CollateralTxIn
{
    public string TxHash { get; init; } = string.Empty;
    public string TxOutputHash { get; init; } = string.Empty;
    public ulong TxOutputIndex { get; init; }
    public string BlockHash { get; set; } = string.Empty;
}