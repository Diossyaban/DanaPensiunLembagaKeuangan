using System.ComponentModel.DataAnnotations;

namespace DPLK.Models.dto
{
    public class EditingDto
    {
        public string register { get; set; }
        [Key]
        public int tfer_type_nmbr { get; set; } //done
        public int trns_seq_nmbr { get; set; } //done
        public int cer_nmbr { get; set; } //done
        public string client_nm { get; set; } //done 
        public string company_nm { get; set; } //done 
        public string tfer_type_nm { get; set; } //done
        public double? tfer_amt { get; set; } //done
        public string bank_central_nm { get; set; } //done
        public string bank_addr { get; set; } //done 
        public string acct_nmbr { get; set; } //done
        public string acct_nm { get; set; } //done
        //public string bank_bi_nmbr { get; set; } //done
        public string kode_bank { get; set; } //done

        public int batch_id { get; set; }
    }
}
