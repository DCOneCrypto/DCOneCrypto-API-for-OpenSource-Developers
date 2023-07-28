using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class MaTxOut
{
    public long Id { get; set; }

    public decimal Quantity { get; set; }

    public long TxOutId { get; set; }

    public long Ident { get; set; }

    public virtual MultiAsset IdentNavigation { get; set; } = null!;

    public virtual TxOut TxOut { get; set; } = null!;
}
