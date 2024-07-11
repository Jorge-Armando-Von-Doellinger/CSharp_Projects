using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Models.Request;

using Domain.Models;

namespace Application.Mapper
{
    public class RequestMapper
    {
        public RequestMapper() 
        { 
        
        }

        public async Task<PatientModel> PatientMapper(PatientRequest patientRequest)
        {
            return new PatientModel
            {
                ID = patientRequest.ID,
                Name = patientRequest.Name,
                LastName = patientRequest.LastName,
                PhoneNumber = patientRequest.PhoneNumber,
                Allergies = patientRequest.Allergies,
                ParantName = patientRequest.ParantName
            };

        }
    }
}
