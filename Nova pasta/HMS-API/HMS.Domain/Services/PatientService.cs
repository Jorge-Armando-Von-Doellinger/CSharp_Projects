using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Repositories;
using HMS.Domain.Interfaces.Repositories.Base;
using HMS.Domain.Interfaces.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;
        private IUnitOfWork _unitOfWork;
        public PatientService(IPatientRepository patientRepository, IUnitOfWork unitOfWork)
        {
            _patientRepository = patientRepository;
        }
        public async Task<PatientEntity?> CreatePatientAsync(PatientEntity patient)
        {
             return await _patientRepository.CreateAsync(patient);
        }

        public async Task<int> DeletePatientAsync(PatientEntity patient)
        {
            int rowsAffected = await _patientRepository.DeleteAsync(patient);
            return rowsAffected;
        }

        public async Task<List<PatientEntity>> GetPatientAsync()
        {
            return await _patientRepository.GetAllAsync();
        }

        public async Task<PatientEntity?> GetPatientByCPFAsync(Int64 CPF)
        {
            return await _patientRepository.GetByCPFAsync(CPF);
        }

        public async Task<PatientEntity?> GetPatientByIdAsync(Int64 ID)
        {
            return await _patientRepository.GetByIdAsync(ID);
        }

        public async Task<List<PatientEntity>> GetPatientByNameAsync(PatientEntity patient)
        {
            return await _patientRepository.GetByNameAsync(patient) ?? default;
        }

        public async Task<PatientEntity?> UpdatePatientAsync(PatientEntity patient)
        {
            return await _patientRepository.UpdateAsync(patient);
        }
    }
}
