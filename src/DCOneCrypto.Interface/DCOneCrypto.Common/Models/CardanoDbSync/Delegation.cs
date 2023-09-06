using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Delegation
{
    public long Id { get; set; }

    public long AddrId { get; set; }

    public int CertIndex { get; set; }

    public long PoolHashId { get; set; }

    public long ActiveEpochNo { get; set; }

    public long TxId { get; set; }

    public long SlotNo { get; set; }

    public long? RedeemerId { get; set; }

    public virtual StakeAddress Addr { get; set; } = null!;

    public virtual PoolHash PoolHash { get; set; } = null!;

    public virtual Redeemer? Redeemer { get; set; }

    public virtual Tx Tx { get; set; } = null!;
}
