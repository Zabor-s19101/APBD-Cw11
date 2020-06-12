using System;
using Microsoft.EntityFrameworkCore;

namespace Cw11.Models {
    public class Cw11DbContext : DbContext {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }

        protected Cw11DbContext() {
        }

        public Cw11DbContext(DbContextOptions options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>(builder => {
                builder.HasKey(e => e.IdDoctor);
                builder.Property(e => e.IdDoctor).ValueGeneratedOnAdd();
                builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
                builder.HasData(
                    new Doctor { IdDoctor = 1, FirstName = "Agnieszka", LastName = "Poterek", Email = "poter123@wp.pl" },
                    new Doctor { IdDoctor = 2, FirstName = "Weronika", LastName = "Janiak", Email = "wjaniak99@gmail.com" },
                    new Doctor { IdDoctor = 3, FirstName = "Anastazja", LastName = "Hrevchenko", Email = "ah1992@wp.pl" },
                    new Doctor { IdDoctor = 4, FirstName = "Jarosław", LastName = "Kraśko", Email = "jk123@wp.pl" },
                    new Doctor { IdDoctor = 5, FirstName = "Paweł", LastName = "Kowalski", Email = "pkowal34@gmail.com" }
                );
            });

            modelBuilder.Entity<Patient>(builder => {
                builder.HasKey(e => e.IdPatient);
                builder.Property(e => e.IdPatient).ValueGeneratedOnAdd();
                builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                builder.Property(e => e.BirthDate).IsRequired();
                builder.HasData(
                    new Patient { IdPatient = 1, FirstName = "Jan", LastName = "Kowalski", BirthDate = DateTime.Parse("1/1/1997") },
                    new Patient { IdPatient = 2, FirstName = "Anna", LastName = "Zawadzka", BirthDate = DateTime.Parse("14/09/1997") },
                    new Patient { IdPatient = 3, FirstName = "Wiktoria", LastName = "Piecyk", BirthDate = DateTime.Parse("05/03/1998") },
                    new Patient { IdPatient = 4, FirstName = "Franciszek", LastName = "Lipski", BirthDate = DateTime.Parse("14/02/1999") },
                    new Patient { IdPatient = 5, FirstName = "Marcin", LastName = "Sosenek", BirthDate = DateTime.Parse("07/07/1996") },
                    new Patient { IdPatient = 6, FirstName = "Kamil", LastName = "Wardal", BirthDate = DateTime.Parse("12/12/1996") },
                    new Patient { IdPatient = 7, FirstName = "Milena", LastName = "Michnik", BirthDate = DateTime.Parse("03/04/1998") }
                );
            });

            modelBuilder.Entity<Prescription>(builder => {
                builder.HasKey(e => e.IdPrescription);
                builder.Property(e => e.IdPrescription).ValueGeneratedOnAdd();
                builder.Property(e => e.Date).IsRequired();
                builder.Property(e => e.DueDate).IsRequired();
                builder.HasOne(d => d.IdDoctorNavigation)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.IdDoctor).IsRequired();
                builder.HasOne(p => p.IdPatientNavigation)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(p => p.IdPatient).IsRequired();
                builder.HasData(
                    new Prescription { IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Parse("25/05/2020"), IdPatient = 2, IdDoctor = 1 },
                    new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Parse("23/06/2020"), IdPatient = 1, IdDoctor = 3 },
                    new Prescription { IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Parse("26/06/2020"), IdPatient = 5, IdDoctor = 3 },
                    new Prescription { IdPrescription = 4, Date = DateTime.Now, DueDate = DateTime.Parse("20/06/2020"), IdPatient = 3, IdDoctor = 4 },
                    new Prescription { IdPrescription = 5, Date = DateTime.Now, DueDate = DateTime.Parse("10/06/2020"), IdPatient = 7, IdDoctor = 2 },
                    new Prescription { IdPrescription = 6, Date = DateTime.Now, DueDate = DateTime.Parse("10/06/2020"), IdPatient = 5, IdDoctor = 5 },
                    new Prescription { IdPrescription = 7, Date = DateTime.Now, DueDate = DateTime.Parse("30/05/2020"), IdPatient = 6, IdDoctor = 1 },
                    new Prescription { IdPrescription = 8, Date = DateTime.Now, DueDate = DateTime.Parse("26/05/2020"), IdPatient = 4, IdDoctor = 2 }
                );
            });

            modelBuilder.Entity<Medicament>(builder => {
                builder.HasKey(e => e.IdMedicament);
                builder.Property(e => e.IdMedicament).ValueGeneratedOnAdd();
                builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
                builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
                builder.Property(e => e.Type).HasMaxLength(100).IsRequired();
                builder.HasData(
                    new Medicament { IdMedicament = 1, Name = "Ibuprom", Description = "dzialanie przeciwbolowe", Type = "doustny" },
                    new Medicament { IdMedicament = 2, Name = "Paracetamol", Description = "działanie przeciwbólowe", Type = "doustny" },
                    new Medicament { IdMedicament = 3, Name = "No-spa", Description = "działanie rozkurczowe", Type = "doustny" },
                    new Medicament { IdMedicament = 4, Name = "Fervex", Description = "działanie przeciwgorączowe", Type = "doustny" },
                    new Medicament { IdMedicament = 5, Name = "WitaminaB12", Description = "działanie przeciwzapalne", Type = "domięśniowy" },
                    new Medicament { IdMedicament = 6, Name = "APAP", Description = "działanie przeciwbólowe", Type = "doustny" },
                    new Medicament { IdMedicament = 7, Name = "Tran", Description = "działanie wzmacniające", Type = "doustny" }
                );
            });

            modelBuilder.Entity<Prescription_Medicament>(builder => {
                builder.HasKey(e => new { e.IdMedicament, e.IdPrescription });
                builder.Property(e => e.Details).HasMaxLength(100).IsRequired();
                builder.HasOne(m => m.IdMedicamentNavigation)
                    .WithMany(pm => pm.PrescriptionMedicaments)
                    .HasForeignKey(m => m.IdMedicament).IsRequired();
                builder.HasOne(p => p.IdPrescriptionNavigation)
                    .WithMany(pm => pm.PrescriptionMedicaments)
                    .HasForeignKey(p => p.IdPrescription).IsRequired();
                builder.HasData(
                    new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 2, Details = "rano i wieczorem" },
                    new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 1, Details = "raz dziennie przed snem" },
                    new Prescription_Medicament { IdMedicament = 3, IdPrescription = 3, Dose = 1, Details = "raz dziennie" },
                    new Prescription_Medicament { IdMedicament = 4, IdPrescription = 4, Dose = 3, Details = "3 razy dziennie" },
                    new Prescription_Medicament { IdMedicament = 5, IdPrescription = 5, Dose = 2, Details = "Po posilku" },
                    new Prescription_Medicament { IdMedicament = 6, IdPrescription = 6, Dose = 1, Details = "raz dziennie" },
                    new Prescription_Medicament { IdMedicament = 7, IdPrescription = 7, Dose = 1, Details = "raz dziennie przez miesiac" },
                    new Prescription_Medicament { IdMedicament = 1, IdPrescription = 8, Dose = 2, Details = "rano i wieczorem" }
                );
            });
        }
    }
}