using HMS.Application.DTOs.Request.Patient;
using HMS.Application.DTOs.Response;
using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Mapper
{
    public static class PatientMapper
    {
        public static async Task<PatientDataResponse> Mapper(PatientEntity patient)
        {
            return new PatientDataResponse()
            {
                CPF = patient.CPF,
                DateBirth = patient.DateBirth,
                Email = patient.Email,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                PhoneNumber = patient.PhoneNumber,
                ScheduledFor = patient.ScheduledFor,
                YearsOld = patient.YearsOld,
                UpdatedAt = patient.UpdatedAt,
                ID = patient.ID
            };
        }
        public static async Task<List<PatientDataResponse>> Mapper(List<PatientEntity> patient)
        {
            List<PatientDataResponse> patients = new List<PatientDataResponse>();
            foreach (PatientEntity patientResponse in patient)
            {
                patients.Add(await Mapper(patientResponse));
            }
            return patients;
        }
        public static async Task<PatientEntity> Mapper(PatientDTO patientDTO)
        {
            return new PatientEntity()
            {
                CPF = patientDTO.CPF,
                DateBirth = patientDTO.DateBirth,
                Email = patientDTO.Email,
                FirstName = patientDTO.FirstName,
                LastName = patientDTO.LastName,
                PhoneNumber = patientDTO.PhoneNumber,
                ScheduledFor = patientDTO.ScheduledFor,
                YearsOld = Calcs.CalculateAge.CalculateYears(patientDTO.DateBirth),
            };
        }
        public static async Task<List<PatientEntity>> Mapper(List<PatientDTO> patientDTO)
        {
            List<PatientEntity> patients = new List<PatientEntity>();
            foreach(var patient in patientDTO)
            {
                patients.Add(await Mapper(patient));
            }
            return patients;
        }
        public static async Task<PatientEntity> Mapper(PatientUpdateDTO EditedPatientDTO)
        {
            return new PatientEntity()
            {
                ID = EditedPatientDTO.ID,
                CPF = EditedPatientDTO.CPF,
                DateBirth = EditedPatientDTO.DateBirth,
                Email = EditedPatientDTO.Email,
                FirstName = EditedPatientDTO.FirstName,
                LastName = EditedPatientDTO.LastName,
                PhoneNumber = EditedPatientDTO.PhoneNumber,
                ScheduledFor = EditedPatientDTO.ScheduledFor,
                YearsOld = Calcs.CalculateAge.CalculateYears(EditedPatientDTO.DateBirth)
            };
        }

        /*public static async Task<PatientDTO> Mapper(PatientEntity patientEntity)
        {
            return new PatientDTO()
            {
                CPF = patientEntity.CPF,
                DateBirth = patientEntity.DateBirth,
                Email = patientEntity.Email,
                FirstName = patientEntity.FirstName,
                LastName = patientEntity.LastName,
                PhoneNumber = patientEntity.PhoneNumber,
                ScheduledFor = patientEntity.ScheduledFor,
                UpdatedAt = patientEntity.UpdatedAt,
                CreatedAt = patientEntity.CreatedAt,
                YearsOld = patientEntity.YearsOld,
            };
        }

        public static async Task<List<PatientDTO>> Mapper(List<PatientEntity> patientEntity)
        {
            List<PatientDTO> patients = new List<PatientDTO>();
            foreach (var patient in patientEntity)
            {
                patients.Add(await Mapper(patient));
            }
            return patients;
        }*/
    }
}
