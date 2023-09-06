using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class CollateralTxOut
{
    public long Id { get; set; }

    public long TxId { get; set; }

    public short Index { get; set; }

    public string Address { get; set; } = null!;

    public byte[] AddressRaw { get; set; } = null!;

    public bool AddressHasScript { get; set; }

    public byte[]? PaymentCred { get; set; }

    public long? StakeAddressId { get; set; }

    public decimal Value { get; set; }

    public byte[]? DataHash { get; set; }

    public string MultiAssetsDescr { get; set; } = null!;

    public long? InlineDatumId { get; set; }

    public long? ReferenceScriptId { get; set; }

    public virtual Datum? InlineDatum { get; set; }

    public virtual Script? ReferenceScript { get; set; }

    public virtual StakeAddress? StakeAddress { get; set; }

    public virtual Tx Tx { get; set; } = null!;
}
