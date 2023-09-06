using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class CostModel
{
    public long Id { get; set; }

    public string Costs { get; set; } = null!;

    public long BlockId { get; set; }

    public byte[] Hash { get; set; } = null!;

    public virtual Block Block { get; set; } = null!;

    public virtual ICollection<EpochParam> EpochParams { get; } = new List<EpochParam>();

    public virtual ICollection<ParamProposal> ParamProposals { get; } = new List<ParamProposal>();
}
