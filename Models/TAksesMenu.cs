using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DPLK.Models
{
    [Keyless]
    [Table("T_Akses_Menu")]
    public partial class TAksesMenu
    {
        [Required]
        [Column("id_profile")]
        [StringLength(50)]
        public string IdProfile { get; set; }
        [Required]
        [Column("id_menu")]
        [StringLength(10)]
        public string IdMenu { get; set; }
    }
}
