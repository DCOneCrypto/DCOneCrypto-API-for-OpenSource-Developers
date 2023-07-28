using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class SlotLeader
{
    public long Id { get; set; }

    public byte[] Hash { get; set; } = null!;

    public long? PoolHashId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Block> Blocks { get; } = new List<Block>();

    public virtual PoolHash? PoolHash { get; set; }
}
