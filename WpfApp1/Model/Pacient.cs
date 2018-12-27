namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pacient")]
    public partial class Pacient
    {
        [Key]
        public int Polis_number { get; set; }

        [Required]
        [StringLength(30)]
        public string FIO { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        // [Column(TypeName = "date")]
        [StringLength(10)]
        public string Birth_day { get; set; }

        [Required]
        [StringLength(30)]
        public string Adres { get; set; }

        public int? Uchastok_number { get; set; }
    }
}
