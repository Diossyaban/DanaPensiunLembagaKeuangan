using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DPLK.Models
{
    [Keyless]
    [Table("T_Group_Menu")]
    public partial class TGroupMenu
    {
        [Required]
        [Column("id_group")]
        [StringLength(10)]
        public string IdGroup { get; set; }
        [Required]
        [Column("nama_group")]
        [StringLength(50)]
        public string NamaGroup { get; set; }
        [Column("urutan")]
        public short Urutan { get; set; }
        [Column("status_group")]
        public short StatusGroup { get; set; }
        [Required]
        [Column("prefix")]
        [StringLength(3)]
        public string Prefix { get; set; }
    }
}
