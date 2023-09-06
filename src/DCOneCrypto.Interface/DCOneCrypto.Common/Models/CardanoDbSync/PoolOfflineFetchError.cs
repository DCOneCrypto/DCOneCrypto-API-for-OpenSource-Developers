using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PoolOfflineFetchError
{
    public long Id { get; set; }

    public long PoolId { get; set; }

    public DateTime FetchTime { get; set; }

    public long PmrId { get; set; }

    public string FetchError { get; set; } = null!;

    public int RetryCount { get; set; }

    public virtual PoolMetadataRef Pmr { get; set; } = null!;

    public virtual PoolHash Pool { get; set; } = null!;
}
