using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class PgStatStatement
{
    public uint? Userid { get; set; }

    public uint? Dbid { get; set; }

    public bool? Toplevel { get; set; }

    public long? Queryid { get; set; }

    public string? Query { get; set; }

    public long? Plans { get; set; }

    public double? TotalPlanTime { get; set; }

    public double? MinPlanTime { get; set; }

    public double? MaxPlanTime { get; set; }

    public double? MeanPlanTime { get; set; }

    public double? StddevPlanTime { get; set; }

    public long? Calls { get; set; }

    public double? TotalExecTime { get; set; }

    public double? MinExecTime { get; set; }

    public double? MaxExecTime { get; set; }

    public double? MeanExecTime { get; set; }

    public double? StddevExecTime { get; set; }

    public long? Rows { get; set; }

    public long? SharedBlksHit { get; set; }

    public long? SharedBlksRead { get; set; }

    public long? SharedBlksDirtied { get; set; }

    public long? SharedBlksWritten { get; set; }

    public long? LocalBlksHit { get; set; }

    public long? LocalBlksRead { get; set; }

    public long? LocalBlksDirtied { get; set; }

    public long? LocalBlksWritten { get; set; }

    public long? TempBlksRead { get; set; }

    public long? TempBlksWritten { get; set; }

    public double? BlkReadTime { get; set; }

    public double? BlkWriteTime { get; set; }

    public long? WalRecords { get; set; }

    public long? WalFpi { get; set; }

    public decimal? WalBytes { get; set; }
}
