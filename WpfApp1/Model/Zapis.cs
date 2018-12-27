namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zapis
    {
        [Key]
        public int Zapis_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Zapis_date { get; set; }

        [StringLength(30)]
        public string Pacient_FIO { get; set; }

        [StringLength(10)]
        public string Zapis_time { get; set; }

        [StringLength(30)]
        public string Doctor_FIO { get; set; }
    }
}
