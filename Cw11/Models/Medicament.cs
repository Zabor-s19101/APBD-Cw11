using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cw11.Models {
    public class Medicament {
        [Key]
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    }
}