using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

[Keyless]
public class AccountListingModel
{
    [Column("trns_seq_nmbr")]
    public string TrnsSeqNmbr { get; set; }

    [Column("trns_hst_efctv_dt")]
    public DateTime TrnsHstEfctvDt { get; set; }

    [Column("source_cer")]
    public string SourceCer { get; set; }

    [Column("source_grp")]
    public string SourceGrp { get; set; }

    [Column("source_nm")]
    public string SourceNm { get; set; }

    [Column("dst_cer")]
    public string DstCer { get; set; }

    [Column("dst_grp")]
    public string DstGrp { get; set; }

    [Column("dst_nm")]
    public string DstNm { get; set; }

    [Column("source_company")]
    public string SourceCompany { get; set; }

    [Column("dst_company")]
    public string DstCompany { get; set; }
}
