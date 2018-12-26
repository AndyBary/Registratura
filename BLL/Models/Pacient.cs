
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
namespace BLL
{
    public class PacientModel
    {
        [Key]
        public int Polis_number { get; set; }

        public string FIO { get; set; }

        public string Gender { get; set; }

        public DateTime Birth_day { get; set; }

        public string Adres { get; set; }

        public int Uchastok_number { get; set; }
    }
}
