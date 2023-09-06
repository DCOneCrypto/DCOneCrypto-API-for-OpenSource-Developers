using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Redeemer
{
    public long Id { get; set; }

    public long TxId { get; set; }

    public long UnitMem { get; set; }

    public long UnitSteps { get; set; }

    public decimal? Fee { get; set; }

    public int Index { get; set; }

    public byte[]? ScriptHash { get; set; }

    public long RedeemerDataId { get; set; }

    public virtual ICollection<Delegation> Delegations { get; } = new List<Delegation>();

    public virtual RedeemerDatum RedeemerData { get; set; } = null!;

    public virtual ICollection<StakeDeregistration> StakeDeregistrations { get; } = new List<StakeDeregistration>();

    public virtual Tx Tx { get; set; } = null!;

    public virtual ICollection<TxIn> TxIns { get; } = new List<TxIn>();

    public virtual ICollection<Withdrawal> Withdrawals { get; } = new List<Withdrawal>();
}
