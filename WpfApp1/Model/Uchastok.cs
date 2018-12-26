namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uchastok")]
    public partial class Uchastok
    {
        public int Number { get; set; }

        public int ID { get; set; }
    }
}
