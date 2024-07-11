using Application.Interfaces.Services;

using Domain.Models;
using API.Models.Response;

using Infrastructure.Data.ApplicationDbContext;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Models.Request;
using Application.Mapper;
using Microsoft.EntityFrameworkCore.Internal;

namespace Application.Services
{
    public class PatientService : IPatientService
    {
        private readonly ApplicationDbContext _context;
        public PatientService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Response<List<PatientModel>>> GetPatients()
        {
            Response<List<PatientModel>> response = new();
            try
            {
                response.Data = await _context.Patient.ToListAsync() 
                    ?? throw new Exception("Nenhum usuario encontrado!");
            }
            catch(Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.ResponseStatus = 400;
            }
            return response;
        }
        public async Task<Response<PatientModel>> GetPatientById(int ID)
        {
            Response<PatientModel> response = new();
            try
            {
                response.Data = await _context.Patient.FindAsync(ID)
                    ?? throw new Exception("Nenhum usuario encontrado!");
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.ResponseStatus = 400;
            }
            return response;
        }
        public async Task<Response<List<PatientModel>>> CreatePatient(PatientRequest patient)
        {
            Response<List<PatientModel>> response = new();
            try
            {
                patient.ID = 0;
                var mapped = new RequestMapper().PatientMapper(patient);
                _context.Patient.Add(await mapped);
                await _context.SaveChangesAsync();
                response.Data = await _context.Patient.ToListAsync();
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.ResponseStatus = 400;
            }
            return response;
        }
        public async Task<Response<List<PatientModel>>> UpdatePatient(PatientRequest editedPatient)
        {
            Response<List<PatientModel>> response = new Response<List<PatientModel>>();
            try
            {
                var _ = await _context.Patient
                    .AsNoTrackingWithIdentityResolution()
                    .FirstOrDefaultAsync(f => f.ID == editedPatient.ID)
                    ?? throw new Exception("Usuario não encontrado!");
                var mapped = await new RequestMapper().PatientMapper(editedPatient);
                _context.Patient.Update(mapped);
                await _context.SaveChangesAsync();
                response.Data = await _context.Patient.ToListAsync();
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.ResponseStatus = 400;
            }
            return response;
        }
        public async Task<Response<List<PatientModel>>> DeletePatient(int ID)
        {
            Response<List<PatientModel>> response = new Response<List<PatientModel>>();
            try
            {
                PatientModel patient = await _context.Patient.FindAsync(ID)
                    ?? throw new Exception("Usuario não encontrado!");
                _context.Patient.RemoveRange(patient);
                await _context.SaveChangesAsync();
                response.Data = _context.Patient.ToList();
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message= ex.Message;
                response.ResponseStatus = 400;
            }
            return response;
        }
    }
}
