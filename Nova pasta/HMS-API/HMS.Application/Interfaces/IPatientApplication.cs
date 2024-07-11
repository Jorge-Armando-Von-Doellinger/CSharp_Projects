using HMS.Application.DTOs.Request.Patient;
using HMS.Application.DTOs.Response;
using HMS.Application.Models;
using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Interfaces
{
    public interface IPatientApplication
    {
        public Task<Response<PatientDataResponse>> GetPatientAsync();
        public Task<Response<PatientDataResponse>> GetPatientByIdAsync(Int64 ID);
        public Task<Response<PatientDataResponse>> GetPatientByCPF(Int64 CPF);
        public Task<Response<PatientDataResponse>> GetPatientByName(string name, string lastname);
        public Task<Response<PatientDataResponse>> CreatePatientAsync(PatientDTO patient);
        public Task<Response<PatientDataResponse>> UpdatePatientAsync(PatientUpdateDTO patient);
        public Task<Response<PatientDataResponse>> DeletePatientAsync(Int64 ID);
    }
}
