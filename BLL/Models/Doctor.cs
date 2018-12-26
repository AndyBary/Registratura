namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class DoctorModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoctorModel()
        {
            Zapis = new HashSet<Zapis>();
        }

        [Key]
        [StringLength(30)]
        public string Kabinet { get; set; }

        [StringLength(30)]
        public string FIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Stag { get; set; }

        public int? Speciality { get; set; }
        
       // public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapis> Zapis { get; set; }
    }
}
