using DPLK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdJurnalTemp
    {
        [Key]
        public string TrnsId { get; set; }
        public string GlCode { get; set; }
        public string Slcode { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public string Inv { get; set; }
        public string Company { get; set; }
        public string Grp { get; set; }
        public string CerNmbr { get; set; }
        public int MonthPeriod { get; set; }
        public int YearPeriod { get; set; }
        public string Description { get; set; }
        public double? Debet { get; set; }
        public double? Credit { get; set; }
        public DateTime DateJurnal { get; set; }
        public bool? Correction { get; set; }

        //public virtual ICollection<SpdFundMapping> Fund { get; set; } //public string Fund { get; set; } menampilkan ini 
        //public virtual ICollection<SpdJurnalKonsolidasiMapping> JurnalKonsolidasiMappings { get; set; }
    }

}

