using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace DPLK.ModelAcc.dto
{
    public class FundData
    {
        [Key]
        public string TrnsId { get; set; }
        public string Description { get; set; }
        public DateTime DateJurnal { get; set; }
        public string Amount { get; set; }
        public string Fund { get; set; }
        public bool? Correction { get; set; }
    }
}
