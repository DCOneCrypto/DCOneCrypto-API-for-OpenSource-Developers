using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;
public partial class TxMetadatum
{
    public long Id { get; set; }

    public decimal Key { get; set; }

    public string? Json { get; set; }

    public byte[] Bytes { get; set; } = null!;

    public long TxId { get; set; }

    public virtual Tx Tx { get; set; } = null!;
}
