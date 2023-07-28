using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PoolHash
{
    public long Id { get; set; }

    public byte[] HashRaw { get; set; } = null!;

    public string View { get; set; } = null!;

    public virtual ICollection<Delegation> Delegations { get; } = new List<Delegation>();

    public virtual ICollection<EpochStake> EpochStakes { get; } = new List<EpochStake>();

    public virtual ICollection<PoolMetadataRef> PoolMetadataRefs { get; } = new List<PoolMetadataRef>();

    public virtual ICollection<PoolOfflineDatum> PoolOfflineData { get; } = new List<PoolOfflineDatum>();

    public virtual ICollection<PoolOfflineFetchError> PoolOfflineFetchErrors { get; } = new List<PoolOfflineFetchError>();

    public virtual ICollection<PoolRetire> PoolRetires { get; } = new List<PoolRetire>();

    public virtual ICollection<PoolUpdate> PoolUpdates { get; } = new List<PoolUpdate>();

    public virtual ICollection<Reward> Rewards { get; } = new List<Reward>();

    public virtual ICollection<SlotLeader> SlotLeaders { get; } = new List<SlotLeader>();
}
