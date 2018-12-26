namespace WpfApp1.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PoliklinikaDB : DbContext
    {
        public PoliklinikaDB()
            : base("name=PoliklinikaDB")
        {
        }

        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Doctors_speciality> Doctors_speciality { get; set; }
        public virtual DbSet<Pacient> Pacient { get; set; }
        public virtual DbSet<Raspisanie> Raspisanie { get; set; }
        public virtual DbSet<Uchastok> Uchastok { get; set; }
        public virtual DbSet<Zapis> Zapis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Speciality)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasOptional(e => e.Doctors_speciality)
                .WithRequired(e => e.Doctor);

            modelBuilder.Entity<Doctors_speciality>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Pacient>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Pacient>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Pacient>()
                .Property(e => e.Adres)
                .IsFixedLength();

            modelBuilder.Entity<Raspisanie>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Raspisanie>()
                .Property(e => e.Speciality)
                .IsFixedLength();

            modelBuilder.Entity<Raspisanie>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Zapis>()
                .Property(e => e.Pacient_FIO)
                .IsFixedLength();

            modelBuilder.Entity<Zapis>()
                .Property(e => e.Zapis_time)
                .IsFixedLength();

            modelBuilder.Entity<Zapis>()
                .Property(e => e.Doctor_FIO)
                .IsFixedLength();
        }
    }
}
