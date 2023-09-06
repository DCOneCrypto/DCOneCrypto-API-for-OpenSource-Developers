using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PoolOfflineDatum
{
    public long Id { get; set; }

    public long PoolId { get; set; }

    public string TickerName { get; set; } = null!;

    public byte[] Hash { get; set; } = null!;

    public string Json { get; set; } = null!;

    public byte[] Bytes { get; set; } = null!;

    public long PmrId { get; set; }

    public virtual PoolMetadataRef Pmr { get; set; } = null!;

    public virtual PoolHash Pool { get; set; } = null!;
}
