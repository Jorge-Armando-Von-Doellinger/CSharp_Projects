using Domain.Models;

using Microsoft.AspNetCore.Mvc;
using API.Models.Response;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Request;

namespace Application.Interfaces.Services
{
    public interface IPatientService
    {
        Task<Response<List<PatientModel>>> GetPatients();
        Task<Response<PatientModel>> GetPatientById(int ID);
        Task<Response<List<PatientModel>>> UpdatePatient(PatientRequest editedPatient);
        Task<Response<List<PatientModel>>> DeletePatient(int ID);
        Task<Response<List<PatientModel>>> CreatePatient(PatientRequest patient);
    }
}
