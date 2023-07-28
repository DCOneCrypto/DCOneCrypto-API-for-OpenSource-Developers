namespace DCOneCrypto.Common.Models;
using System.Numerics;

public class SwapDatum
{
    public AssetClass Base { get; set; } = new();
    public AssetClass Quote { get; set; } = new();
    public AssetClass Nft { get; set; } = new();
    public BigInteger ExFeePerTokenNum { get; set; }
    public BigInteger ExFeePerTokenDen { get; set; }
    public BigInteger BaseAmount { get; set; }
    public BigInteger MinQuoteAmount { get; set; }
    public string RewardPkh { get; set; } = string.Empty;
    public string? StakePkh { get; set; }
    public uint Fee { get; set; }

    public override string ToString()
    {
        return $@"
        Base: {Base}
        Quote: {Quote}
        Nft: {Nft.PolicyId + Nft.Name}
        ExFeePerTokenNum: {ExFeePerTokenNum}
        ExFeePerTokenDen: {ExFeePerTokenDen}
        BaseAmount: {BaseAmount}
        MinQuoteAmount: {MinQuoteAmount}
        RewardPkh: {RewardPkh}
        StakePkh: {StakePkh}
        Fee: {Fee}";
    }
}