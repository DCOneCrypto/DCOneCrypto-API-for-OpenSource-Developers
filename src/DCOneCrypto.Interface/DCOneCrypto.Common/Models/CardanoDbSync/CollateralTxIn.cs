using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class CollateralTxIn
{
    public long Id { get; set; }

    public long TxInId { get; set; }

    public long TxOutId { get; set; }

    public short TxOutIndex { get; set; }

    public virtual Tx TxIn { get; set; } = null!;

    public virtual Tx TxOut { get; set; } = null!;
}
