using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class MaTxMint
{
    public long Id { get; set; }

    public decimal Quantity { get; set; }

    public long TxId { get; set; }

    public long Ident { get; set; }

    public virtual MultiAsset IdentNavigation { get; set; } = null!;

    public virtual Tx Tx { get; set; } = null!;
}
