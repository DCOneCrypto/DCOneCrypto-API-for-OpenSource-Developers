using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class EpochStake
{
    public long Id { get; set; }

    public long AddrId { get; set; }

    public long PoolId { get; set; }

    public decimal Amount { get; set; }

    public int EpochNo { get; set; }

    public virtual StakeAddress Addr { get; set; } = null!;

    public virtual PoolHash Pool { get; set; } = null!;
}
