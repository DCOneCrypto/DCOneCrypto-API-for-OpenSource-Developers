using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PoolOwner
{
    public long Id { get; set; }

    public long AddrId { get; set; }

    public long PoolUpdateId { get; set; }

    public virtual StakeAddress Addr { get; set; } = null!;

    public virtual PoolUpdate PoolUpdate { get; set; } = null!;
}
