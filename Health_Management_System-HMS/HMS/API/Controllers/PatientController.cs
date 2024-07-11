using Application.Interfaces.Services;
using Application.Models.Request;
using Application.Services;

using Domain.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PatientModel>>> GetPatient()
        {
            return Ok(await _patientService.GetPatients());
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<List<PatientModel>>> GetPatientById(int ID)
        {
            return Ok(await _patientService.GetPatientById(ID));
        }
        [HttpPost]
        public async Task<ActionResult<List<PatientModel>>> CreatePatient(PatientRequest newPatient)
        {
            return Ok(await _patientService.CreatePatient(newPatient));
        }
        [HttpPut]
        public async Task<ActionResult<List<PatientModel>>> UpdatePatient(PatientRequest editedPatient)
        {
            return Ok(await _patientService.UpdatePatient(editedPatient));
        }
        [HttpDelete("{ID}")]
        public async Task<ActionResult<List<PatientModel>>> UpdatePatient(int ID)
        {
            return Ok(await _patientService.DeletePatient(ID));
        }
    }
}
