using System.Runtime.InteropServices;

namespace DCOneCrypto.Common.Models;

public class NftOwner
{
    public string Address { get; set; } = string.Empty;
    public string PolicyId { get; init; } = string.Empty;
    public string TokenName { get; init; } = string.Empty;
    public string? StakeAddress { get; set; } = string.Empty;
}