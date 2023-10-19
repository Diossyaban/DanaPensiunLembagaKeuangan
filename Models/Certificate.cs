using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Certificate
    {
        public Certificate()
        {
            CerAccumulators = new HashSet<CerAccumulator>();
            CerCntrbs = new HashSet<CerCntrb>();
            CerInvDrcts = new HashSet<CerInvDrct>();
            CerInvs = new HashSet<CerInv>();
            CerMovements = new HashSet<CerMovement>();
            CerStatuses = new HashSet<CerStatus>();
            CerTrnsCnts = new HashSet<CerTrnsCnt>();
        }

        public int CerNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int ClientNmbr { get; set; }
        public string OldCerNmbr { get; set; }
        public string EmployeeNmbr { get; set; }
        public string Employee2Nmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? TerminationDt { get; set; }
        public DateTime? EmploymentDt { get; set; }
        public int RetirementAge { get; set; }
        public int? PaycenterNmbr { get; set; }
        public short? PaymentTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public short? AppStatusNmbr { get; set; }
        public DateTime? CompletionDt { get; set; }
        public DateTime? AppReceiveDt { get; set; }
        public short? CitizenshipCd { get; set; }
        public string TaxIdNmbr { get; set; }
        public short? JobVctnNmbr { get; set; }
        public short? FundSrcNmbr { get; set; }
        public DateTime? MaturityDt { get; set; }
        public short OthDppkFlg { get; set; }
        public DateTime? PinPrintDt { get; set; }
        public int? CerNmbrOpf { get; set; }
        public DateTime? KitDeliveryDt { get; set; }
        public bool? FirstPremiumFlg { get; set; }
        public string Branch { get; set; }
        public string SalesName { get; set; }
        public short? PremiumTypeNmbr { get; set; }
        public short? RiderTypeNmbr { get; set; }
        public short? CommisionTypeNmbr { get; set; }
        public short? PlanTypeNmbr { get; set; }
        public short? FlagKomisi { get; set; }
        public string VAccNmbr { get; set; }
        public short? FlagKomisi1 { get; set; }
        public short? FlagKomisi2 { get; set; }
        public short? ApuPpt { get; set; }

        public virtual ICollection<CerAccumulator> CerAccumulators { get; set; }
        public virtual ICollection<CerCntrb> CerCntrbs { get; set; }
        public virtual ICollection<CerInvDrct> CerInvDrcts { get; set; }
        public virtual ICollection<CerInv> CerInvs { get; set; }
        public virtual ICollection<CerMovement> CerMovements { get; set; }
        public virtual ICollection<CerStatus> CerStatuses { get; set; }
        public virtual ICollection<CerTrnsCnt> CerTrnsCnts { get; set; }
    }
}
