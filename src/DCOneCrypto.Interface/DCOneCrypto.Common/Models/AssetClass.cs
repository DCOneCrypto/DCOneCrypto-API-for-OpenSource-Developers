namespace DCOneCrypto.Common.Models;

public partial class AssetClass
{
    public string PolicyId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? AsciiName { get; set; }
    public string? Metadata { get; set; }
}