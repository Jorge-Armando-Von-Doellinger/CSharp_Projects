using MetroFramework.Controls;

using PatientFoms.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientFoms.Mapper
{
    public static class PatientMapper
    {
        public static PatientRequest Mapper(PatientResponse response)
        {
            return new PatientRequest()
            {
                CPF = response.CPF,
                DateBirth = response.DateBirth,
                Email = response.Email,
                FirstName = response.FirstName,
                LastName = response.LastName,
                PhoneNumber = response.PhoneNumber,
                ID = response.ID
            };
        }
    }
}
