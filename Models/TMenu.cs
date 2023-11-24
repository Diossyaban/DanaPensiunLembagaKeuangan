using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DPLK.Models
{
 
    [Table("T_Menu")]
    public partial class TMenu
    {
        [Key]
        [Required]
        [Column("id_group")]
        [StringLength(10)]
        public string IdGroup { get; set; }
        [Required]
        [Column("id_menu")]
        [StringLength(10)]
        public string IdMenu { get; set; }
        [Column("id_parent")]
        [StringLength(10)]
        public string IdParent { get; set; }
        [Column("nama_menu")]
        [StringLength(50)]
        public string NamaMenu { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("level")]
        public short? Level { get; set; }
        [Column("status_menu")]
        public short StatusMenu { get; set; }
    }
}
