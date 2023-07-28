using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class AdaPot
{
    public long Id { get; set; }

    public long SlotNo { get; set; }

    public int EpochNo { get; set; }

    public decimal Treasury { get; set; }

    public decimal Reserves { get; set; }

    public decimal Rewards { get; set; }

    public decimal Utxo { get; set; }

    public decimal Deposits { get; set; }

    public decimal Fees { get; set; }

    public long BlockId { get; set; }

    public virtual Block Block { get; set; } = null!;
}
