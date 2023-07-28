using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class RedeemerDatum
{
    public long Id { get; set; }

    public byte[] Hash { get; set; } = null!;

    public long TxId { get; set; }

    public string? Value { get; set; }

    public byte[] Bytes { get; set; } = null!;

    public virtual ICollection<Redeemer> Redeemers { get; } = new List<Redeemer>();

    public virtual Tx Tx { get; set; } = null!;
}
