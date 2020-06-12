﻿// <auto-generated />
using System;
using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cw11.Migrations
{
    [DbContext(typeof(Cw11DbContext))]
    partial class Cw11DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "poter123@wp.pl",
                            FirstName = "Agnieszka",
                            LastName = "Poterek"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "wjaniak99@gmail.com",
                            FirstName = "Weronika",
                            LastName = "Janiak"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "ah1992@wp.pl",
                            FirstName = "Anastazja",
                            LastName = "Hrevchenko"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "jk123@wp.pl",
                            FirstName = "Jarosław",
                            LastName = "Kraśko"
                        },
                        new
                        {
                            IdDoctor = 5,
                            Email = "pkowal34@gmail.com",
                            FirstName = "Paweł",
                            LastName = "Kowalski"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "dzialanie przeciwbolowe",
                            Name = "Ibuprom",
                            Type = "doustny"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "działanie przeciwbólowe",
                            Name = "Paracetamol",
                            Type = "doustny"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "działanie rozkurczowe",
                            Name = "No-spa",
                            Type = "doustny"
                        },
                        new
                        {
                            IdMedicament = 4,
                            Description = "działanie przeciwgorączowe",
                            Name = "Fervex",
                            Type = "doustny"
                        },
                        new
                        {
                            IdMedicament = 5,
                            Description = "działanie przeciwzapalne",
                            Name = "WitaminaB12",
                            Type = "domięśniowy"
                        },
                        new
                        {
                            IdMedicament = 6,
                            Description = "działanie przeciwbólowe",
                            Name = "APAP",
                            Type = "doustny"
                        },
                        new
                        {
                            IdMedicament = 7,
                            Description = "działanie wzmacniające",
                            Name = "Tran",
                            Type = "doustny"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(1997, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anna",
                            LastName = "Zawadzka"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(1998, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Wiktoria",
                            LastName = "Piecyk"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = new DateTime(1999, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Franciszek",
                            LastName = "Lipski"
                        },
                        new
                        {
                            IdPatient = 5,
                            BirthDate = new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Marcin",
                            LastName = "Sosenek"
                        },
                        new
                        {
                            IdPatient = 6,
                            BirthDate = new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kamil",
                            LastName = "Wardal"
                        },
                        new
                        {
                            IdPatient = 7,
                            BirthDate = new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Milena",
                            LastName = "Michnik"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 339, DateTimeKind.Local).AddTicks(1696),
                            DueDate = new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6514),
                            DueDate = new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 3,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6603),
                            DueDate = new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 3,
                            IdPatient = 5
                        },
                        new
                        {
                            IdPrescription = 4,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6616),
                            DueDate = new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 4,
                            IdPatient = 3
                        },
                        new
                        {
                            IdPrescription = 5,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6626),
                            DueDate = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 2,
                            IdPatient = 7
                        },
                        new
                        {
                            IdPrescription = 6,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6636),
                            DueDate = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 5,
                            IdPatient = 5
                        },
                        new
                        {
                            IdPrescription = 7,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6645),
                            DueDate = new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 6
                        },
                        new
                        {
                            IdPrescription = 8,
                            Date = new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6655),
                            DueDate = new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 2,
                            IdPatient = 4
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("PrescriptionMedicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "rano i wieczorem",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "raz dziennie przed snem",
                            Dose = 1
                        },
                        new
                        {
                            IdMedicament = 3,
                            IdPrescription = 3,
                            Details = "raz dziennie",
                            Dose = 1
                        },
                        new
                        {
                            IdMedicament = 4,
                            IdPrescription = 4,
                            Details = "3 razy dziennie",
                            Dose = 3
                        },
                        new
                        {
                            IdMedicament = 5,
                            IdPrescription = 5,
                            Details = "Po posilku",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 6,
                            IdPrescription = 6,
                            Details = "raz dziennie",
                            Dose = 1
                        },
                        new
                        {
                            IdMedicament = 7,
                            IdPrescription = 7,
                            Details = "raz dziennie przez miesiac",
                            Dose = 1
                        },
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 8,
                            Details = "rano i wieczorem",
                            Dose = 2
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription", b =>
                {
                    b.HasOne("Cw11.Models.Doctor", "IdDoctorNavigation")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cw11.Models.Patient", "IdPatientNavigation")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cw11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("Cw11.Models.Medicament", "IdMedicamentNavigation")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cw11.Models.Prescription", "IdPrescriptionNavigation")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}