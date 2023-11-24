using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DPLK.Models
{
   
    [Table("T_User")]
    public partial class TUser
    {
        [Key]
        [Required]
        [Column("id_user")]
        [StringLength(50)]
        public string IdUser { get; set; }
        [Required]
        [Column("nama_lengkap")]
        public string NamaLengkap { get; set; }
        [Column("bagian")]
        [StringLength(100)]
        public string Bagian { get; set; }
        [Column("jabatan")]
        [StringLength(50)]
        public string Jabatan { get; set; }
        [Column("status_user")]
        public short StatusUser { get; set; }
        [Column("email")]
        [StringLength(200)]
        public string Email { get; set; }
    }
}
