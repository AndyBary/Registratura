namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Raspisanie")]
    public partial class Raspisanie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kabinet_vracha { get; set; }

        [StringLength(30)]
        public string FIO { get; set; }

        [StringLength(30)]
        public string Speciality { get; set; }

        public TimeSpan? Nachalo_priema { get; set; }

        public TimeSpan? Konec_priema { get; set; }

        [StringLength(10)]
        public string Status { get; set; }
    }
}
