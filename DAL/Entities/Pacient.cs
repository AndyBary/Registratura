namespace DAL
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Polis_number { get; set; }

        [Required]
        [StringLength(30)]
        public string FIO { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birth_day { get; set; }

        [Required]
        [StringLength(30)]
        public string Adres { get; set; }

        public int Uchastok_number { get; set; }


   
    }
}
