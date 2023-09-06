namespace DCOneCrypto.Common.Models;

public class RedeemDatum
{
    public AssetClass Nft { get; set; } = new();
    public AssetClass ReserveX { get; set; } = new();
    public AssetClass ReserveY { get; set; } = new();
    public AssetClass Lq { get; set; } = new();
    public uint ExFee { get; set; }
    public string RewardPkh { get; set; } = string.Empty;
    public string? StakePkh { get; set; }

    public override string ToString()
    {
        return $@"
        Nft: {Nft.PolicyId + Nft.Name}
        ReserveX: {ReserveX.PolicyId + ReserveX.Name}
        ReserveY: {ReserveY.PolicyId + ReserveY.Name}
        Lq: {Lq.PolicyId + Lq.Name}
        ExFee: {ExFee}
        RewardPkh: {RewardPkh}
        StakePkh: {StakePkh}";
    }
}