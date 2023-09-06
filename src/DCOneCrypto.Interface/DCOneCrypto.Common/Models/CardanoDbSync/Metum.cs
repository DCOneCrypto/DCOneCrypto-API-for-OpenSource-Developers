using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Metum
{
    public long Id { get; set; }

    public DateTime StartTime { get; set; }

    public string NetworkName { get; set; } = null!;

    public string Version { get; set; } = null!;
}
