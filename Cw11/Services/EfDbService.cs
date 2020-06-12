using System;
using System.Collections.Generic;
using System.Linq;
using Cw11.DTOs.Requests;
using Cw11.Models;

namespace Cw11.Services {
    public class EfDbService : IDbService {
        private readonly Cw11DbContext _context;

        public EfDbService(Cw11DbContext context) {
            _context = context;
        }

        public List<Doctor> GetDoctors() {
            return _context.Doctors.ToList();
        }

        public void CreateDoctor(CreateDoctorRequest request) {
            _context.Doctors.Add(new Doctor {
                IdDoctor = request.IdDoctor,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            });
            _context.SaveChanges();
        }

        public void UpdateDoctor(CreateDoctorRequest request) {
            var doctor = _context.Doctors.SingleOrDefault(d => d.IdDoctor == request.IdDoctor);
            if (doctor == null) {
                throw new Exception("Nie ma takiego doktora");
            }
            doctor.IdDoctor = request.IdDoctor;
            doctor.FirstName = request.FirstName;
            doctor.LastName = request.LastName;
            doctor.Email = request.Email;
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id) {
            _context.Remove(_context.Doctors.Single(d => d.IdDoctor == id));
            _context.SaveChanges();
        }
    }
}