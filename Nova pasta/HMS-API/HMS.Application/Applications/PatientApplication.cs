using HMS.Application.DTOs.Request.Patient;
using HMS.Application.DTOs.Response;
using HMS.Application.Interfaces;
using HMS.Application.Mapper;
using HMS.Application.Models;
using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Repositories;
using HMS.Domain.Interfaces.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Applications
{
    public class PatientApplication : IPatientApplication
    {
        private IPatientService _patientService;
        private Response<PatientDataResponse> response;
        public PatientApplication(IPatientService patientService)
        {
            _patientService = patientService;
            response = new();
        }
        public async Task<Response<PatientDataResponse>> CreatePatientAsync(PatientDTO patient)
        {
            try
            {
                PatientEntity patientEntity = await PatientMapper.Mapper(patient);
                PatientEntity? patientCreated = await _patientService.CreatePatientAsync(patientEntity);
                response.SingleData = await PatientMapper.Mapper(patientCreated);
            }
            catch (NullReferenceException)
            {
                response.SingleData = null;
                response.Message = "Dados não aceitos!";
                response.Success = false;
            }
            catch (Exception ex)
            {
                response.SingleData = null;
                response.Message = ex.Message;
                response.Success = false;

            }
            return response;
        }

        public async Task<Response<PatientDataResponse>> DeletePatientAsync(Int64 ID)
        {
            try
            {
                var patient = new PatientEntity() { ID = ID };
                int rowsAffected = await _patientService.DeletePatientAsync(patient);
                if (rowsAffected == 1)
                    response.Message = "Deletado com sucesso!";
                else
                    throw new Exception("Houve um erro ao excluir este paciente. Tente novamente mais tarde!");
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        public async Task<Response<PatientDataResponse>> GetPatientAsync()
        {
            try
            {
                response.Data = await PatientMapper.Mapper(await _patientService.GetPatientAsync());
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<PatientDataResponse>> GetPatientByCPF(Int64 CPF)
        {
            try
            {
                PatientDataResponse patient = await PatientMapper.Mapper(await _patientService.GetPatientByCPFAsync(CPF))
                ?? throw new Exception("Paciente não encontrado!");
                response.SingleData = patient;
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.SingleData = null;
            }
            return response;
        }

        public async Task<Response<PatientDataResponse>> GetPatientByIdAsync(Int64 ID)
        {
            try 
            {
                PatientDataResponse patient = await PatientMapper.Mapper(await _patientService.GetPatientByIdAsync(ID))
                ?? throw new Exception("Paciente não encontrado!");
                response.SingleData = patient;
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.SingleData = null;
            }
            return response;
        }

        public async Task<Response<PatientDataResponse>> GetPatientByName(string name, string lastname)
        {
            try
            {
                PatientEntity entity = new() { FirstName = name, LastName = lastname };
                List<PatientEntity> patientsByName = await _patientService.GetPatientByNameAsync(entity);
                response.Data = await PatientMapper.Mapper(patientsByName);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.SingleData = null;
            }
            return response;

        }

        public async Task<Response<PatientDataResponse>> UpdatePatientAsync(PatientUpdateDTO patient)
        {
            try
            {
                PatientEntity entity = await PatientMapper.Mapper(patient);
                response.SingleData = await PatientMapper.Mapper(await _patientService.UpdatePatientAsync(entity));
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.SingleData = null;
            }
            return response;
        }
    }
}
