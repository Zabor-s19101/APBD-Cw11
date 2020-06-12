using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw11.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    IdPatient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    IdPatient = table.Column<int>(nullable: false),
                    IdDoctor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "FK_Prescription_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescription_Patients_IdPatient",
                        column: x => x.IdPatient,
                        principalTable: "Patients",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionMedicaments",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false),
                    IdPrescription = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: true),
                    Details = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionMedicaments", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicaments_Medicaments_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicaments",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicaments_Prescription_IdPrescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "poter123@wp.pl", "Agnieszka", "Poterek" },
                    { 2, "wjaniak99@gmail.com", "Weronika", "Janiak" },
                    { 3, "ah1992@wp.pl", "Anastazja", "Hrevchenko" },
                    { 4, "jk123@wp.pl", "Jarosław", "Kraśko" },
                    { 5, "pkowal34@gmail.com", "Paweł", "Kowalski" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 7, "działanie wzmacniające", "Tran", "doustny" },
                    { 6, "działanie przeciwbólowe", "APAP", "doustny" },
                    { 4, "działanie przeciwgorączowe", "Fervex", "doustny" },
                    { 5, "działanie przeciwzapalne", "WitaminaB12", "domięśniowy" },
                    { 2, "działanie przeciwbólowe", "Paracetamol", "doustny" },
                    { 1, "dzialanie przeciwbolowe", "Ibuprom", "doustny" },
                    { 3, "działanie rozkurczowe", "No-spa", "doustny" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 6, new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamil", "Wardal" },
                    { 1, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Kowalski" },
                    { 2, new DateTime(1997, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Zawadzka" },
                    { 3, new DateTime(1998, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wiktoria", "Piecyk" },
                    { 4, new DateTime(1999, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franciszek", "Lipski" },
                    { 5, new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcin", "Sosenek" },
                    { 7, new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milena", "Michnik" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6514), new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 1, new DateTime(2020, 6, 12, 22, 6, 29, 339, DateTimeKind.Local).AddTicks(1696), new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 4, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6616), new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 8, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6655), new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 3, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6603), new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 6, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6636), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 7, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6645), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 5, new DateTime(2020, 6, 12, 22, 6, 29, 342, DateTimeKind.Local).AddTicks(6626), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 2, 2, "raz dziennie przed snem", 1 },
                    { 1, 1, "rano i wieczorem", 2 },
                    { 4, 4, "3 razy dziennie", 3 },
                    { 1, 8, "rano i wieczorem", 2 },
                    { 3, 3, "raz dziennie", 1 },
                    { 6, 6, "raz dziennie", 1 },
                    { 7, 7, "raz dziennie przez miesiac", 1 },
                    { 5, 5, "Po posilku", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicaments_IdPrescription",
                table: "PrescriptionMedicaments",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionMedicaments");

            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
