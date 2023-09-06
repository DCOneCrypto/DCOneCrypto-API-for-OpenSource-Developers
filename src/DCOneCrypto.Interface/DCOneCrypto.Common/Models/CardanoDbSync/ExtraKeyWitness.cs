using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class ExtraKeyWitness
{
    public long Id { get; set; }

    public byte[] Hash { get; set; } = null!;

    public long TxId { get; set; }

    public virtual Tx Tx { get; set; } = null!;
}
