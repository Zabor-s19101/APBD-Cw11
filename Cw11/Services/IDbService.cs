using System.Collections.Generic;
using Cw11.DTOs.Requests;
using Cw11.Models;

namespace Cw11.Services {
    public interface IDbService {
        List<Doctor> GetDoctors();
        void CreateDoctor(CreateDoctorRequest request);
        void UpdateDoctor(CreateDoctorRequest request);
        void DeleteDoctor(int id);
    }
}