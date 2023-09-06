using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PoolUpdate
{
    public long Id { get; set; }

    public long HashId { get; set; }

    public int CertIndex { get; set; }

    public byte[] VrfKeyHash { get; set; } = null!;

    public decimal Pledge { get; set; }

    public long ActiveEpochNo { get; set; }

    public long? MetaId { get; set; }

    public double Margin { get; set; }

    public decimal FixedCost { get; set; }

    public long RegisteredTxId { get; set; }

    public long RewardAddrId { get; set; }

    public virtual PoolHash Hash { get; set; } = null!;

    public virtual PoolMetadataRef? Meta { get; set; }

    public virtual ICollection<PoolOwner> PoolOwners { get; } = new List<PoolOwner>();

    public virtual ICollection<PoolRelay> PoolRelays { get; } = new List<PoolRelay>();

    public virtual Tx RegisteredTx { get; set; } = null!;

    public virtual StakeAddress RewardAddr { get; set; } = null!;
}
