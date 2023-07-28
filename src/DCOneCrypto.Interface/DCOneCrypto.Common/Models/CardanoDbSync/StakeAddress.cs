using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class StakeAddress
{
    public long Id { get; set; }

    public byte[] HashRaw { get; set; } = null!;

    public string View { get; set; } = null!;

    public byte[]? ScriptHash { get; set; }

    public long TxId { get; set; }

    public virtual ICollection<CollateralTxOut> CollateralTxOuts { get; } = new List<CollateralTxOut>();

    public virtual ICollection<Delegation> Delegations { get; } = new List<Delegation>();

    public virtual ICollection<EpochStake> EpochStakes { get; } = new List<EpochStake>();

    public virtual ICollection<PoolOwner> PoolOwners { get; } = new List<PoolOwner>();

    public virtual ICollection<PoolUpdate> PoolUpdates { get; } = new List<PoolUpdate>();

    public virtual ICollection<Reserve> Reserves { get; } = new List<Reserve>();

    public virtual ICollection<Reward> Rewards { get; } = new List<Reward>();

    public virtual ICollection<StakeDeregistration> StakeDeregistrations { get; } = new List<StakeDeregistration>();

    public virtual ICollection<StakeRegistration> StakeRegistrations { get; } = new List<StakeRegistration>();

    public virtual ICollection<Treasury> Treasuries { get; } = new List<Treasury>();

    public virtual Tx Tx { get; set; } = null!;

    public virtual ICollection<TxOut> TxOuts { get; } = new List<TxOut>();

    public virtual ICollection<Withdrawal> Withdrawals { get; } = new List<Withdrawal>();
}
