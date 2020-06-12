using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cw11.Models {
    public class Patient {
        [Key]
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}