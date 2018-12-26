
namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DAL.Entities;

    public partial class PoliklinikaDB : DbContext
    {
        public PoliklinikaDB()
            : base("name=PoliklinikaDB")
        {
        }

        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Doctors_speciality> Doctors_speciality { get; set; }
        public virtual DbSet<Pacient> Pacient { get; set; }
        public virtual DbSet<Uchastok> Raspisanie { get; set; }
        public virtual DbSet<Zapis> Zapis { get; set; }
        public virtual DbSet<Raspisanie> Raspisanie1 { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.FIO)
                .IsFixedLength();

            /*modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Zapis)
                .WithOptional(e => e.Doctor)
                .HasForeignKey(e => e.FIO);*/

            modelBuilder.Entity<Doctors_speciality>()
                .Property(e => e.Name_of_speciality)
                .IsFixedLength();

            /*modelBuilder.Entity<Doctors_speciality>()
                .HasMany(e => e.Doctor)
                .WithOptional(e => e.Speciality)
                .HasForeignKey(e => e.Speciality_code);*/

            modelBuilder.Entity<Pacient>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Pacient>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Pacient>()
                .Property(e => e.Adres)
                .IsFixedLength();
        }
    }
}
