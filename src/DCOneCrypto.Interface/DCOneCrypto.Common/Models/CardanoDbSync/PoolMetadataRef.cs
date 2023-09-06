using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PoolMetadataRef
{
    public long Id { get; set; }

    public long PoolId { get; set; }

    public string Url { get; set; } = null!;

    public byte[] Hash { get; set; } = null!;

    public long RegisteredTxId { get; set; }

    public virtual PoolHash Pool { get; set; } = null!;

    public virtual ICollection<PoolOfflineDatum> PoolOfflineData { get; } = new List<PoolOfflineDatum>();

    public virtual ICollection<PoolOfflineFetchError> PoolOfflineFetchErrors { get; } = new List<PoolOfflineFetchError>();

    public virtual ICollection<PoolUpdate> PoolUpdates { get; } = new List<PoolUpdate>();

    public virtual Tx RegisteredTx { get; set; } = null!;
}
