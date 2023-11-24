using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DPLK.Models
{
    [Table("T_Log_Activity")]
    public partial class TLogActivity
    {
        [Key]
        [Column("ipaddress")]
        [StringLength(50)]
        public string Ipaddress { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("activitytype")]
        public int? Activitytype { get; set; }
        [Column("info", TypeName = "text")]
        public string Info { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
    }
}
