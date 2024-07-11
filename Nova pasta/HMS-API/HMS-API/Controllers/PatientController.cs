using HMS.Application.DTOs.Request.Patient;
using HMS.Application.Interfaces;
using HMS.Application.Models;
using HMS.Domain.Entities;

using Microsoft.AspNetCore.Mvc;

namespace HMS_API.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IPatientApplication _patientApplication;
        public PatientController(IPatientApplication patientApplication)
        {
            _patientApplication = patientApplication;
        }

        [HttpGet]
        public async Task<ActionResult> GetPatient()
        {
            return Ok(await _patientApplication.GetPatientAsync());
        }

        [HttpGet("{ID}")]
        public async Task<ActionResult> GetPatientById(Int64 ID)
        {
            return Ok(await _patientApplication.GetPatientByIdAsync(ID));
        }
        [HttpGet("find/name")]
        public async Task<ActionResult> GetPatientByName([FromQuery]string? name, [FromQuery]string? lastname)
        {
            return name != null || lastname != null ?
                Ok(await _patientApplication.GetPatientByName(name, lastname))
                : BadRequest("Nome e sobrenome nulos");
        }
        [HttpGet("find/cpf/{CPF}")]
        public async Task<ActionResult> GetPatientByCPF(Int64 CPF)
        {
            return Ok(await _patientApplication.GetPatientByCPF(CPF));
        }

        [HttpPost]
        public async Task<ActionResult<Response<PatientDTO>>> CreatePatient(PatientDTO patient)
        {
            return Ok(await _patientApplication.CreatePatientAsync(patient));
        }

        [HttpPut]
        public async Task<ActionResult<Response<PatientDTO>>> UpdatePatient(PatientUpdateDTO patient)
        {
            return Ok(await _patientApplication.UpdatePatientAsync(patient));
            
        }

        [HttpDelete("{ID}")]
        public async Task<ActionResult<Response<PatientDTO>>> DeletePatient(Int64 ID)
        {
            return Ok(await _patientApplication.DeletePatientAsync(ID));
        }
    }
}
