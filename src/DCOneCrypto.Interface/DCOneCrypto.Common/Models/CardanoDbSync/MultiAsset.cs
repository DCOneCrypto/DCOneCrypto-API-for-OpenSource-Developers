using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class MultiAsset
{
    public long Id { get; set; }

    public byte[] Policy { get; set; } = null!;

    public byte[] Name { get; set; } = null!;

    public string Fingerprint { get; set; } = null!;

    public virtual ICollection<MaTxMint> MaTxMints { get; } = new List<MaTxMint>();

    public virtual ICollection<MaTxOut> MaTxOuts { get; } = new List<MaTxOut>();
}
