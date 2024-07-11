using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.DTOs.Request.Patient
{
    public class PatientUpdateDTO : PatientDTO
    {
        public Int64 ID { get; set; }
    }
}
