using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Interfaces.Services
{
    public interface IPatientService 
    {
        public Task<List<PatientEntity>> GetPatientAsync();
        public Task<PatientEntity?> GetPatientByIdAsync(Int64 ID);
        public Task<List<PatientEntity>> GetPatientByNameAsync(PatientEntity patient);
        public Task<PatientEntity?> GetPatientByCPFAsync(Int64 CPF);
        public Task<PatientEntity?> CreatePatientAsync(PatientEntity patient);
        public Task<PatientEntity?> UpdatePatientAsync(PatientEntity patient);
        public Task<int> DeletePatientAsync(PatientEntity patient);
    }
}
