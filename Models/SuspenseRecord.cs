using Microsoft.EntityFrameworkCore;
using System;

namespace DPLK.Models
{
    [Keyless]
    public class SuspenseRecord
    {
        public long suspn_nmbr { get; set; }
/*        public double? SUSPENSE_AMT { get; set; }
        public double? SUSPENSE_USE_AMT { get; set; }*/
        public string REST_AMT { get; set; }
        public string suspn_desc1 { get; set; }
        public int? suspn_type_nm { get; set; } // Menggunakan int nullable
        /*        public DateTime RECEIVED_DATE { get; set; }
        */
        public int group_nmbr { get; set; }
        public string company_nm { get; set; }
        public string PAYCENTER_nm { get; set; }
/*        public DateTime datesorting { get; set; }
*/        public string Ref_Bank { get; set; }
    }
}
