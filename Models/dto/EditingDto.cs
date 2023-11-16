using System.ComponentModel.DataAnnotations;

namespace DPLK.Models.dto
{
    public class EditingDto
    {
        public string register { get; set; }
        [Key]
        public int tfer_type_nmbr { get; set; }
        public int trns_seq_nmbr { get; set; }
        public string cer_nmbr { get; set; }
        public string client_nm { get; set; }
        public string company_nm { get; set; }
        public string tfer_type_nm { get; set; }
        public decimal tfer_amt { get; set; }
        public string bank_central_nm { get; set; }
        public string bank_addr { get; set; }
        public string acct_nmbr { get; set; }
        public string acct_nm { get; set; }
        public string kode_bank { get; set; }
        public int batch_id { get; set; }
    }
}
