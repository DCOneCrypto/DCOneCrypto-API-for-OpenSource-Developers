using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class TableBloat
{
    public decimal? TRealSize { get; set; }

    public double? TExtraSize { get; set; }

    public double? TExtraRatio { get; set; }

    public int? TFillFactor { get; set; }

    public double? TBloatSize { get; set; }

    public double? TBloatRatio { get; set; }

    public bool? TIsNa { get; set; }
}
