using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DAL.Entities
{
    [Table("Raspisanie")]
    public partial class Raspisanie
    {
        [Key]
        public int Kabinet_vracha { get; set; }

        public string FIO { get; set; }

        public string Speciality { get; set; }

        public TimeSpan Nachalo_priema { get; set; }

        public TimeSpan Konec_priema { get; set; }

        [StringLength(10)]
        public string Status { get; set; }
    }
}
