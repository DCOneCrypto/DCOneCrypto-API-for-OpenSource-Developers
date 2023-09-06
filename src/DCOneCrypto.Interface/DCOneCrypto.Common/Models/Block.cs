namespace DCOneCrypto.Common.Models;

public class Block
{
    public string BlockHash { get; set; } = string.Empty;
    public string Era { get; set; } = string.Empty;
    public string VrfKeyhash { get; set; } = string.Empty;
    public ulong BlockNumber { get; set; }
    public ulong Slot { get; set; }
    public ulong Epoch { get; set; }
    public IEnumerable<ulong>? InvalidTransactions { get; set; }
}