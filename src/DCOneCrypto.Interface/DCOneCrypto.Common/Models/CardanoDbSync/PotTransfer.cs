using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PotTransfer
{
    public long Id { get; set; }

    public int CertIndex { get; set; }

    public decimal Treasury { get; set; }

    public decimal Reserves { get; set; }

    public long TxId { get; set; }

    public virtual Tx Tx { get; set; } = null!;
}
