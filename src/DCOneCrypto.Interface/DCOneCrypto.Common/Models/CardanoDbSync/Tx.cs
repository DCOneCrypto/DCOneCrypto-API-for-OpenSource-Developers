using System;
using System.Collections.Generic;

namespace DCOneCrypto.Common.Models.CardanoDbSync;

public partial class Tx
{
    public long Id { get; set; }

    public byte[] Hash { get; set; } = null!;

    public long BlockId { get; set; }

    public int BlockIndex { get; set; }

    public decimal OutSum { get; set; }

    public decimal Fee { get; set; }

    public long Deposit { get; set; }

    public int Size { get; set; }

    public decimal? InvalidBefore { get; set; }

    public decimal? InvalidHereafter { get; set; }

    public bool ValidContract { get; set; }

    public int ScriptSize { get; set; }

    public virtual Block Block { get; set; } = null!;

    public virtual ICollection<CollateralTxIn> CollateralTxInTxIns { get; } = new List<CollateralTxIn>();

    public virtual ICollection<CollateralTxIn> CollateralTxInTxOuts { get; } = new List<CollateralTxIn>();

    public virtual ICollection<CollateralTxOut> CollateralTxOuts { get; } = new List<CollateralTxOut>();

    public virtual ICollection<Datum> Data { get; } = new List<Datum>();

    public virtual ICollection<Delegation> Delegations { get; } = new List<Delegation>();

    public virtual ICollection<ExtraKeyWitness> ExtraKeyWitnesses { get; } = new List<ExtraKeyWitness>();

    public virtual ICollection<MaTxMint> MaTxMints { get; } = new List<MaTxMint>();

    public virtual ICollection<ParamProposal> ParamProposals { get; } = new List<ParamProposal>();

    public virtual ICollection<PoolMetadataRef> PoolMetadataRefs { get; } = new List<PoolMetadataRef>();

    public virtual ICollection<PoolRetire> PoolRetires { get; } = new List<PoolRetire>();

    public virtual ICollection<PoolUpdate> PoolUpdates { get; } = new List<PoolUpdate>();

    public virtual ICollection<PotTransfer> PotTransfers { get; } = new List<PotTransfer>();

    public virtual ICollection<RedeemerDatum> RedeemerData { get; } = new List<RedeemerDatum>();

    public virtual ICollection<Redeemer> Redeemers { get; } = new List<Redeemer>();

    public virtual ICollection<ReferenceTxIn> ReferenceTxInTxIns { get; } = new List<ReferenceTxIn>();

    public virtual ICollection<ReferenceTxIn> ReferenceTxInTxOuts { get; } = new List<ReferenceTxIn>();

    public virtual ICollection<Reserve> Reserves { get; } = new List<Reserve>();

    public virtual ICollection<Script> Scripts { get; } = new List<Script>();

    public virtual ICollection<StakeAddress> StakeAddresses { get; } = new List<StakeAddress>();

    public virtual ICollection<StakeDeregistration> StakeDeregistrations { get; } = new List<StakeDeregistration>();

    public virtual ICollection<StakeRegistration> StakeRegistrations { get; } = new List<StakeRegistration>();

    public virtual ICollection<Treasury> Treasuries { get; } = new List<Treasury>();

    public virtual ICollection<TxIn> TxInTxInNavigations { get; } = new List<TxIn>();

    public virtual ICollection<TxIn> TxInTxOuts { get; } = new List<TxIn>();

    public virtual ICollection<TxMetadatum> TxMetadata { get; } = new List<TxMetadatum>();

    public virtual ICollection<TxOut> TxOuts { get; } = new List<TxOut>();

    public virtual ICollection<Withdrawal> Withdrawals { get; } = new List<Withdrawal>();
}
