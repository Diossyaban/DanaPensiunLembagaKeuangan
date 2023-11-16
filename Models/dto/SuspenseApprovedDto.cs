using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DPLK.Models.dto
{
    public class SuspenseApprovedDto
    {
        public long suspn_nmbr { get; set; }
        public string SUSPENSE_AMT { get; set; }
        public string SUSPENSE_USE_AMT { get; set; }
        public string REST_AMT { get; set; }
        public string suspn_desc1 { get; set; }
        public string suspn_type_nm { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? RECEIVED_DATE
        {
            get
            {
                if (DateTime.TryParseExact(_receivedDate, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                return null;
            }
            set
            {
                _receivedDate = value?.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        private string _receivedDate;

        [Key]
        public int? group_nmbr { get; set; }
        public string company_nm { get; set; }
        public string PAYCENTER_nm { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? datesorting
        {
            get
            {
                if (DateTime.TryParseExact(_datesorting, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                return null;
            }
            set
            {
                _datesorting = value?.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        private string _datesorting;

        public string Ref_Bank { get; set; }
    }
}
