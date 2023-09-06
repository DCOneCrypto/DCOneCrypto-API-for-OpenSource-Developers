using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class IndexBloat
{
    public decimal? IRealSize { get; set; }

    public decimal? IExtraSize { get; set; }

    public double? IExtraRatio { get; set; }

    public int? IFillFactor { get; set; }

    public double? IBloatSize { get; set; }

    public double? IBloatRatio { get; set; }

    public bool? IIsNa { get; set; }
}
