namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [Key]
        [StringLength(30)]
        public string Kabinet { get; set; }

        [StringLength(30)]
        public string FIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Stag { get; set; }

        public virtual Doctors_speciality Speciality { get; set; }
    }
}
