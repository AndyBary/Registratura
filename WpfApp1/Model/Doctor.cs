namespace WpfApp1.Model
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kabinet { get; set; }

        [StringLength(30)]
        public string FIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Stag { get; set; }

        [StringLength(50)]
        public string Speciality { get; set; }

        public virtual Doctors_speciality Doctors_speciality { get; set; }
    }
}
