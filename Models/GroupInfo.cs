using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GroupInfo
    {
        public GroupInfo()
        {
            ContribReqs = new HashSet<ContribReq>();
            GroupCharges = new HashSet<GroupCharge>();
            GrpVestSches = new HashSet<GrpVestSch>();
            MbrClsPlans = new HashSet<MbrClsPlan>();
            WdAccumulators = new HashSet<WdAccumulator>();
        }

        public int GroupNmbr { get; set; }
        public int? ProductType { get; set; }
        public DateTime? TerminationDt { get; set; }
        public DateTime? CaseCloseDt { get; set; }
        public DateTime EfctvDt { get; set; }
        public int ClientNmbr { get; set; }
        public short IndGrpCd { get; set; }
        public int AllowWithNmbr { get; set; }
        public int WithYear { get; set; }
        public double? MinAnnuityPrct { get; set; }
        public double? MinAnnuityAmt { get; set; }
        public int? AnlMaxWithFreq { get; set; }
        public double? MinWithAmt { get; set; }
        public double? MaxWithPrct { get; set; }
        public int? MinYrForWith { get; set; }
        public int? EarlyRetireAge { get; set; }
        public int? NormalRetireAge { get; set; }
        public double? MinCntrbAmt { get; set; }
        public double? MaxCntrbAmt { get; set; }
        public short? WithSrcTypeNmbr { get; set; }
        public short? InclContribFlg { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? AffiliatedTo { get; set; }
        public short? PremiumMtdType { get; set; }
        public short? MaturityTypeNmbr { get; set; }
        public string MaturityVal { get; set; }
        public DateTime? CreateDt { get; set; }
        public int? MailAddrOpt { get; set; }
        public int? BillPayctrOpt { get; set; }
        public int? PslPaymentFreq { get; set; }
        public DateTime? BackdatedEfctvDt { get; set; }
        public short? AccbalFreqNmbr { get; set; }
        public short? SupportUu1992 { get; set; }
        public DateTime? CompletedDt { get; set; }
        public DateTime? AccbalLstprnDt { get; set; }
        public int? ProrateFeeFlg { get; set; }
        public DateTime? MppTerminationDt { get; set; }
        public DateTime? SpakRecvDt { get; set; }
        public short? HavePsl { get; set; }
        public short? PslType { get; set; }
        public int? PooledFlg { get; set; }
        public string OldGrpNmbr { get; set; }
        public int? ClaimProcessDay { get; set; }
        public string VaCurrencyNmbr { get; set; }
        public string VaDplkNmbr { get; set; }
        public int? CommisionType { get; set; }
        public int? CommisionFlg { get; set; }
        public int? AgentNmbr { get; set; }

        public virtual BillingStatus BillingStatus { get; set; }
        public virtual ICollection<ContribReq> ContribReqs { get; set; }
        public virtual ICollection<GroupCharge> GroupCharges { get; set; }
        public virtual ICollection<GrpVestSch> GrpVestSches { get; set; }
        public virtual ICollection<MbrClsPlan> MbrClsPlans { get; set; }
        public virtual ICollection<WdAccumulator> WdAccumulators { get; set; }
        public virtual Company Company { get; set; }

    }
}
