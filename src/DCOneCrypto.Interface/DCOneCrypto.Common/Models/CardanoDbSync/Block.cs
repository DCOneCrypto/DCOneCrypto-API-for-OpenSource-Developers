using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Block
{
    public long Id { get; set; }

    public byte[] Hash { get; set; } = null!;

    public int? EpochNo { get; set; }

    public long? SlotNo { get; set; }

    public int? EpochSlotNo { get; set; }

    public int? BlockNo { get; set; }

    public long? PreviousId { get; set; }

    public long SlotLeaderId { get; set; }

    public int Size { get; set; }

    public DateTime Time { get; set; }

    public long TxCount { get; set; }

    public int ProtoMajor { get; set; }

    public int ProtoMinor { get; set; }

    public string? VrfKey { get; set; }

    public byte[]? OpCert { get; set; }

    public long? OpCertCounter { get; set; }

    public virtual AdaPot? AdaPot { get; set; }

    public virtual ICollection<CostModel> CostModels { get; } = new List<CostModel>();

    public virtual ICollection<EpochParam> EpochParams { get; } = new List<EpochParam>();

    public virtual ICollection<Block> InversePrevious { get; } = new List<Block>();

    public virtual Block? Previous { get; set; }

    public virtual SlotLeader SlotLeader { get; set; } = null!;

    public virtual ICollection<Tx> Txes { get; } = new List<Tx>();
}
