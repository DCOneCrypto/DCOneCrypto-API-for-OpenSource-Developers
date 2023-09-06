using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Reserve
{
    public long Id { get; set; }

    public long AddrId { get; set; }

    public int CertIndex { get; set; }

    public decimal Amount { get; set; }

    public long TxId { get; set; }

    public virtual StakeAddress Addr { get; set; } = null!;

    public virtual Tx Tx { get; set; } = null!;
}
