using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Reward
{
    public long Id { get; set; }

    public long AddrId { get; set; }

    public decimal Amount { get; set; }

    public long EarnedEpoch { get; set; }

    public long SpendableEpoch { get; set; }

    public long? PoolId { get; set; }

    public virtual StakeAddress Addr { get; set; } = null!;

    public virtual PoolHash? Pool { get; set; }
}
