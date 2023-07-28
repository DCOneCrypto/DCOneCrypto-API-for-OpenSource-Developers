using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Datum
{
    public long Id { get; set; }

    public byte[] Hash { get; set; } = null!;

    public long TxId { get; set; }

    public string? Value { get; set; }

    public byte[] Bytes { get; set; } = null!;

    public virtual ICollection<CollateralTxOut> CollateralTxOuts { get; } = new List<CollateralTxOut>();

    public virtual Tx Tx { get; set; } = null!;

    public virtual ICollection<TxOut> TxOuts { get; } = new List<TxOut>();
}
