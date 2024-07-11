using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Interfaces.Repositories
{
    public interface IPatientRepository
    {
        public Task<List<PatientEntity>> GetAllAsync();
        public Task<PatientEntity> GetByIdAsync(Int64 ID);
        public Task<PatientEntity> GetByCPFAsync(Int64 CPF);
        public Task<List<PatientEntity>> GetByNameAsync(PatientEntity patient);
        public Task<PatientEntity?> CreateAsync(PatientEntity patient);
        public Task<PatientEntity?> UpdateAsync(PatientEntity patient);
        public Task<int> DeleteAsync(PatientEntity patient); 
    }
}
